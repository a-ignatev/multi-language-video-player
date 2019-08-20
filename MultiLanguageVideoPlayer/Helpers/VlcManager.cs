using System.Diagnostics;

namespace MultiLanguageVideoPlayer.Helpers
{
    public class VlcManager
    {
        private Process _vlcplayer;
        private Process _vlcplayer2;

        public bool IsInitialized =>
            _vlcplayer != null && _vlcplayer2 != null &&
            !_vlcplayer.HasExited && !_vlcplayer2.HasExited;

        public void Init(string leftAudioDevice, string rightAudioDevice, int position)
        {
            Trace.WriteLine("Init Vlc Manager");
            _vlcplayer = CreateVlcProcess(leftAudioDevice, VlcClient.FirstPlayerPort, position);
            _vlcplayer.Start();

            _vlcplayer2 = CreateVlcProcess(rightAudioDevice, VlcClient.SecondPlayerPort, position);
            _vlcplayer2.Start();
        }

        private static Process CreateVlcProcess(string audioDevice, string port, int position)
        {
            return new Process
            {
                StartInfo =
                {
                    FileName = Properties.Settings.Default.VlcPath,
                    Arguments =
                        $"--aout=directx --directx-audio-device=\"{audioDevice}\" -I http --http-host localhost --http-port {port} --http-password=\"1\" --start-time={position}",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = false
                }
            };
        }

        internal void Stop()
        {
            Trace.WriteLine("Stop Vlc Manager");

            if (_vlcplayer != null && !_vlcplayer.HasExited)
                _vlcplayer.Kill();
            if (_vlcplayer2 != null && !_vlcplayer2.HasExited)
                _vlcplayer2.Kill();
        }
    }
}
