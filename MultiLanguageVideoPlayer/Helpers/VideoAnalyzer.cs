using System;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using DirectShowLib;
using MultiLanguageVideoPlayer.Model;

namespace MultiLanguageVideoPlayer.Helpers
{
    public class VideoAnalyzer
    {
        public VideoAnalyzer(string filePath, Action<VideoInfo> callback)
        {
            var videoInfo = new VideoInfo();
            AddVideoMetadata(filePath, videoInfo);
            AddAudioDevices(videoInfo);
            callback.Invoke(videoInfo);
        }
        private void AddVideoMetadata(string filePath, VideoInfo videoInfo)
        {
            var ffmpeg = new Process
            {
                StartInfo =
                {
                    FileName = "./ffmpeg/ffmpeg.exe",
                    Arguments = $@"-i ""{filePath}""",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                }
            };

            DataReceivedEventHandler outputHandler = (_, e) =>
            {
                if (e.Data != null)
                {
                    if (e.Data.Contains("Audio"))
                    {
                        videoInfo.AudioTracks.Add(e.Data);
                    }
                    else if (e.Data.Contains("Duration"))
                    {
                        var durationTimeString = e.Data.Split(',').First().Split(new[] {':'}, 2).Last().Trim();
                        videoInfo.Duration = TimeHelper.StringToSeconds(durationTimeString);
                    }
                }
            };

            ffmpeg.OutputDataReceived += outputHandler;
            ffmpeg.ErrorDataReceived += outputHandler;

            ffmpeg.Start();
            ffmpeg.BeginOutputReadLine();
            ffmpeg.BeginErrorReadLine();
            ffmpeg.WaitForExit();
        }

        private void AddAudioDevices(VideoInfo videoInfo)
        {
            var audioRenderers = DsDevice.GetDevicesOfCat(FilterCategory.AudioRendererCategory);

            foreach (var device in audioRenderers)
            {
                var deviceId = Regex.Replace(device.DevicePath, ".*\\\\", string.Empty);
                var guidMatch = Regex.Match(deviceId, "{[^}]+}");
                if (guidMatch.Success)
                {
                    var deviceGuid = guidMatch.Value;
                    if (!videoInfo.AudioDevices.ContainsValue(deviceGuid))
                    {
                        videoInfo.AudioDevices.Add(device.Name, deviceGuid);
                    }
                }
            }
        }
    }
}