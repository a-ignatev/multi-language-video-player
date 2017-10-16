using System;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using DirectShowLib;
using MultiLanguageVideoPlayer.Model;

namespace MultiLanguageVideoPlayer
{
    public class VideoAnalyzer
    {
        private readonly string _filePath;
        private readonly VideoInfo _videoInfo;

        public VideoAnalyzer(string filePath, Action<VideoInfo> callback)
        {
            _filePath = filePath;
            _videoInfo = new VideoInfo();
            GetAudioTracks();
            GetAudioDevices();
            GetVideoDuration();
            callback.Invoke(_videoInfo);
        }

        private void GetVideoDuration()
        {
            try
            {
                double length;
                var graphFilter = new FilterGraph();
                var graphBuilder = (IFilterGraph2) graphFilter;
                graphBuilder.RenderFile(_filePath, null);
                var mediaPos = (IMediaPosition) graphBuilder;
                mediaPos.get_Duration(out length);
                _videoInfo.Duration = (int) length;
            }
            catch
            {
                _videoInfo.Duration = 0;
            }
        }

        private void GetAudioTracks()
        {
            var ffmpeg = new Process
            {
                StartInfo =
                {
                    FileName = "./ffmpeg/ffmpeg.exe",
                    Arguments = $@"-i ""{_filePath}""",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                }
            };

            ffmpeg.OutputDataReceived += OutputHandler;
            ffmpeg.ErrorDataReceived += OutputHandler;

            ffmpeg.Start();
            ffmpeg.BeginOutputReadLine();
            ffmpeg.BeginErrorReadLine();
            ffmpeg.WaitForExit();
        }

        public void GetAudioDevices()
        {
            var audioRenderers = DsDevice.GetDevicesOfCat(FilterCategory.AudioRendererCategory);

            foreach (var device in audioRenderers)
            {
                var deviceId = Regex.Replace(device.DevicePath, ".*\\\\", string.Empty);
                var guidMatch = Regex.Match(deviceId, "{[^}]+}");
                if (!guidMatch.Success)
                    continue;

                var deviceGuid = guidMatch.Value;
                if (!_videoInfo.AudioDevices.ContainsValue(deviceGuid))
                    _videoInfo.AudioDevices.Add(device.Name, deviceGuid);
            }

            _videoInfo.AudioDevices.Distinct();
        }

        private void OutputHandler(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null && e.Data.Contains("Audio"))
                _videoInfo.AudioTracks.Add(e.Data);
        }
    }
}