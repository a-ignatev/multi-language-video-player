using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Xml.Serialization;
using MultiLanguageVideoPlayer.Helper;
using MultiLanguageVideoPlayer.Model;
using Timer = System.Timers.Timer;

namespace MultiLanguageVideoPlayer
{
    public partial class MainForm : Form
    {
        private string _filePath;
        private Process _vlcplayer;
        private Process _vlcplayer2;

        private const int FirstPlayerPort = 9090;
        private const int SecondPlayerPort = 9091;

        private bool _isPlaying;
        private VideoInfo _videoInfo;
        private readonly Timer _timer;
        private readonly object _lockObject = new object();
        private bool _ignoreBar;

        public MainForm()
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(Properties.Settings.Default.VlcPath))
                VlcPathText.Text = Properties.Settings.Default.VlcPath;

            _timer = new Timer(1000);
            _timer.Elapsed += (sender, args) =>
            {
                lock (_lockObject)
                {
                    if (_isPlaying)
                    {
                        var currentTime = GetCurrentTime();
                        UpdateVideoPosition(currentTime);
                    }
                }
            };
            _timer.AutoReset = true;
            _timer.Enabled = true;
        }

        private void UpdateVideoPosition(int time)
        {
            _ignoreBar = true;
            VideoPosition.Invoke((MethodInvoker) delegate
            {
                VideoPosition.Value = time;
                _ignoreBar = false;
            });
        }

        private void UpdateUi()
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.VlcPath) && !string.IsNullOrEmpty(_filePath) &&
                LeftAudioTrack.SelectedIndex >= 0 && LeftAudioDevice.SelectedIndex >= 0 &&
                RightAudioTrack.SelectedIndex >= 0 && RightAudioDevice.SelectedIndex >= 0)
            {
                PlayButton.Enabled = !_isPlaying;
                StopButton.Enabled = _isPlaying;
                PauseButton.Enabled = _isPlaying;
            }
            else
            {
                PlayButton.Enabled = false;
                StopButton.Enabled = false;
                PauseButton.Enabled = false;
            }
        }

        private void FileBrowseButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                SelectedFileLabel.Visible = true;
                _filePath = openFileDialog.FileName;
                SelectedFileLabel.Text = Path.GetFileName(openFileDialog.FileName);
                Text = Path.GetFileName(openFileDialog.FileName);

                new VideoAnalyzer(openFileDialog.FileName, videoinfo =>
                {
                    _videoInfo = videoinfo;

                    LeftAudioTrack.Items.Clear();
                    LeftAudioDevice.Items.Clear();
                    RightAudioTrack.Items.Clear();
                    RightAudioDevice.Items.Clear();

                    foreach (var audioTrack in videoinfo.AudioTracks)
                    {
                        LeftAudioTrack.Items.Add(audioTrack);
                        RightAudioTrack.Items.Add(audioTrack);
                    }

                    foreach (var audioDevice in videoinfo.AudioDevices)
                    {
                        LeftAudioDevice.Items.Add(audioDevice.Key);
                        RightAudioDevice.Items.Add(audioDevice.Key);
                    }

                    VideoPosition.SetRange(0, videoinfo.Duration);
                    VideoTimeLabel.Visible = true;
                    VideoPosition.Enabled = true;
                    UpdateVideoTime();
                });

                if (Properties.Settings.Default.DefaultLeftDevice >= 0 &&
                    Properties.Settings.Default.DefaultLeftDevice < LeftAudioDevice.Items.Count)
                    LeftAudioDevice.SelectedIndex = Properties.Settings.Default.DefaultLeftDevice;

                if (Properties.Settings.Default.DefaultRightDevice >= 0 &&
                    Properties.Settings.Default.DefaultRightDevice < RightAudioDevice.Items.Count)
                    RightAudioDevice.SelectedIndex = Properties.Settings.Default.DefaultRightDevice;

                if (Properties.Settings.Default.DefaultLeftTrack >= 0 &&
                    Properties.Settings.Default.DefaultLeftTrack < LeftAudioTrack.Items.Count)
                    LeftAudioTrack.SelectedIndex = Properties.Settings.Default.DefaultLeftTrack;

                if (Properties.Settings.Default.DefaultRightTrack >= 0 &&
                    Properties.Settings.Default.DefaultRightTrack < RightAudioTrack.Items.Count)
                    RightAudioTrack.SelectedIndex = Properties.Settings.Default.DefaultRightTrack;
            }
        }

        private void UpdateVideoTime()
        {
            VideoTimeLabel.Text =
                $@"{TimeHelper.SecondsToString(VideoPosition.Value)} - {
                        TimeHelper.SecondsToString(_videoInfo.Duration)
                    }";
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            _isPlaying = true;
            UpdateUi();

            if (_vlcplayer == null && _vlcplayer2 == null ||
                _vlcplayer != null && _vlcplayer.HasExited ||
                _vlcplayer2 != null && _vlcplayer2.HasExited)
            {
                _vlcplayer = new Process
                {
                    StartInfo =
                    {
                        FileName = Properties.Settings.Default.VlcPath,
                        Arguments =
                            $"{_filePath} --aout=directx --directx-audio-device=\"{_videoInfo.AudioDevices[LeftAudioDevice.SelectedItem.ToString()]}\" -I http --http-host localhost --http-port {FirstPlayerPort} --http-password=\"1\" --start-time={VideoPosition.Value}",
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true
                    }
                };

                _vlcplayer2 = new Process
                {
                    StartInfo =
                    {
                        FileName = Properties.Settings.Default.VlcPath,
                        Arguments =
                            $"{_filePath} --aout=directx --directx-audio-device=\"{_videoInfo.AudioDevices[RightAudioDevice.SelectedItem.ToString()]}\" -I http --http-host localhost --http-port {SecondPlayerPort} --http-password=\"1\" --start-time={VideoPosition.Value}",
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true
                    }
                };

                _vlcplayer.Start();
                _vlcplayer2.Start();
                SetAudioTracks();
            }
            else
            {
                RequestPlayerCommand("pl_play");
            }
        }

        private void RefreshPlayButton_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUi();

            if ((ListBox) sender == LeftAudioDevice)
            {
                Properties.Settings.Default.DefaultLeftDevice = LeftAudioDevice.SelectedIndex;
                Properties.Settings.Default.Save();
            }

            if ((ListBox) sender == RightAudioDevice)
            {
                Properties.Settings.Default.DefaultRightDevice = RightAudioDevice.SelectedIndex;
                Properties.Settings.Default.Save();
            }

            if ((ListBox) sender == LeftAudioTrack)
            {
                Properties.Settings.Default.DefaultLeftTrack = LeftAudioTrack.SelectedIndex;
                Properties.Settings.Default.Save();
            }

            if ((ListBox) sender == RightAudioTrack)
            {
                Properties.Settings.Default.DefaultRightTrack = RightAudioTrack.SelectedIndex;
                Properties.Settings.Default.Save();
            }
        }

        private void VlcPathBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                VlcPathText.Text = openFileDialog.FileName;
                Properties.Settings.Default.VlcPath = openFileDialog.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            _isPlaying = false;
            UpdateUi();

            RequestPlayerCommand("pl_stop");
            if (_vlcplayer != null && !_vlcplayer.HasExited)
                _vlcplayer.Kill();
            if (_vlcplayer2 != null && !_vlcplayer2.HasExited)
                _vlcplayer2.Kill();
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            _isPlaying = false;
            UpdateUi();
            RequestPlayerCommand("pl_pause");
        }

        private void RequestPlayerCommand(string command)
        {
            if (_vlcplayer == null || _vlcplayer.HasExited || _vlcplayer2 == null || _vlcplayer2.HasExited)
                return;

            MakeRequestInternal(command, FirstPlayerPort);
            MakeRequestInternal(command, SecondPlayerPort);
        }

        private void SetAudioTracks()
        {
            var request =
                (HttpWebRequest)WebRequest.Create("http://localhost:" + FirstPlayerPort +
                                                  "/requests/status.xml?command=audio_track&val=" + (LeftAudioTrack.SelectedIndex + 1));
            request.Headers.Add("Authorization",
                "Basic " + Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(":1")));
            request.GetResponse();

            var request2 =
                (HttpWebRequest)WebRequest.Create("http://localhost:" + SecondPlayerPort +
                                                  "/requests/status.xml?command=audio_track&val=" + (RightAudioTrack.SelectedIndex + 1));
            request2.Headers.Add("Authorization",
                "Basic " + Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(":1")));
            request2.GetResponse();
        }

        private static void SeekTo(int value)
        {
            var request =
                (HttpWebRequest) WebRequest.Create("http://localhost:" + FirstPlayerPort +
                                                   "/requests/status.xml?command=seek&val=" + value);
            request.Headers.Add("Authorization",
                "Basic " + Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(":1")));
            request.GetResponse();

            var request2 =
                (HttpWebRequest) WebRequest.Create("http://localhost:" + SecondPlayerPort +
                                                   "/requests/status.xml?command=seek&val=" + value);
            request2.Headers.Add("Authorization",
                "Basic " + Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(":1")));
            request2.GetResponse();
        }

        private static void MakeRequestInternal(string command, int port)
        {
            var request =
                (HttpWebRequest) WebRequest.Create("http://localhost:" + port +
                                                   "/requests/status.xml?command=" + command);
            request.Headers.Add("Authorization",
                "Basic " + Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(":1")));
            request.GetResponse();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopButton_Click(sender, e);
        }

        private void VideoPosition_ValueChanged(object sender, EventArgs e)
        {
            UpdateVideoTime();
            if (_isPlaying && !_ignoreBar)
                SeekTo(VideoPosition.Value);
        }

        private static int GetCurrentTime()
        {
            var request =
                (HttpWebRequest) WebRequest.Create("http://localhost:" + FirstPlayerPort + "/requests/status.xml");
            request.Headers.Add("Authorization",
                "Basic " + Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(":1")));
            var response = request.GetResponse();

            PlaybackStatus playbackStatus = null;
            if (response.GetResponseStream() != null)
                playbackStatus = (PlaybackStatus) new XmlSerializer(typeof(PlaybackStatus)).Deserialize(response.GetResponseStream());

            return playbackStatus?.Time ?? 0;
        }
    }
}