using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using MultiLanguageVideoPlayer.Model;

namespace MultiLanguageVideoPlayer.Helpers
{
    public static class VlcClient
    {
        public const int FirstPlayerPort = 1234;
        public const int SecondPlayerPort = 1235;

        private static string RequestInternal(string command, int port)
        {
            try
            {
                Trace.WriteLine(">> " + command);
                var client = new TcpClient("127.0.0.1", port);
                var networkStream = client.GetStream();
                var data = Encoding.UTF8.GetBytes(command + "\n");
                networkStream.Write(data, 0, data.Length);

                client.Client.Shutdown(SocketShutdown.Send);

                var r = Read(networkStream, port);

                networkStream.Dispose();

                return r;
            }
            catch (Exception e)
            {
                // todo add some logic
                Trace.WriteLine(e.Message);
                return null;
            }
        }

        private static string Read(Stream networkStream, int port)
        {
            var resp = new byte[2048];
            var memStream = new MemoryStream();
            if (networkStream.CanRead)
            {
                var bytesRead = networkStream.Read(resp, 0, resp.Length);
                while (bytesRead > 0)
                {
                    memStream.Write(resp, 0, bytesRead);
                    bytesRead = networkStream.Read(resp, 0, resp.Length);
                }

                var response = Encoding.UTF8.GetString(memStream.ToArray());
                Console.WriteLine($@"{port} << {response}");

                return response;
            }

            return string.Empty;
        }

        public static void SeekTo(int value)
        {
            Trace.WriteLine("Seek To: " + value);

            var command = "seek " + value;
            RequestInternal(command, FirstPlayerPort);
            RequestInternal(command, SecondPlayerPort);
        }

        public static void SetAudioTracks(int leftAudioTrack, int rightAudioTrack)
        {
            Trace.WriteLine("SetAudioTracks: " + leftAudioTrack + ", " + rightAudioTrack);

            RequestInternal("atrack " + leftAudioTrack, FirstPlayerPort);
            RequestInternal("atrack " + rightAudioTrack, SecondPlayerPort);
        }

        public static void SetAudioDevices(string leftAudioDevice, string rightAudioDevice)
        {
            Trace.WriteLine("SetAudioDevices: " + leftAudioDevice + ", " + rightAudioDevice);

            RequestInternal("adev " + leftAudioDevice, FirstPlayerPort);
            RequestInternal("adev " + rightAudioDevice, SecondPlayerPort);
        }

        public static void TogglePause()
        {
            Trace.WriteLine("TogglePause");

            RequestInternal("pause", FirstPlayerPort);
            RequestInternal("pause", SecondPlayerPort);
        }

        public static void Stop()
        {
            Trace.WriteLine("Stop");

            RequestInternal("stop", FirstPlayerPort);
            RequestInternal("stop", SecondPlayerPort);
        }

        public static void AddFile(string filePath, bool showVideoForLeft)
        {
            Trace.WriteLine("AddFile: " + filePath);

            RequestInternal("add " + filePath, FirstPlayerPort);
            RequestInternal("add " + filePath, SecondPlayerPort);
            RequestInternal("vtrack -1" + filePath, showVideoForLeft ? SecondPlayerPort : FirstPlayerPort);
        }

        public static VideoInfo GetFileInfo(string filePath)
        {
            Trace.WriteLine("GetFileInfo: " + filePath);

            RequestInternal("add " + filePath, FirstPlayerPort);
            RequestInternal("atrack -1" + filePath, FirstPlayerPort);
            RequestInternal("vtrack -1" + filePath, FirstPlayerPort);

            Thread.Sleep(250);

            var duration = GetInteger(RequestInternal("get_length", FirstPlayerPort));
            var title = RequestInternal("get_title", FirstPlayerPort);

            var audioTracks = new List<string>();
            var audioTracksResponse = RequestInternal("atrack", FirstPlayerPort)
                .Split(new[] {'\r', '\n'}, StringSplitOptions.RemoveEmptyEntries)
                .Where(x => x.StartsWith("|"))
                .Skip(1);

            foreach (var track in audioTracksResponse)
            {
                audioTracks.Add(Regex.Match(track, "- (?<name>.*)").Groups["name"].Value.Replace("*", "").Trim());
            }

            var audioDevices = new Dictionary<string, string>();
            var audioDevicesResponse = RequestInternal("adev", FirstPlayerPort);
            foreach (Match match in Regex.Matches(audioDevicesResponse, @"\|.*?(?<guid>\{[^\s]+) - (?<name>.*?)\r\n"))
            {
                audioDevices.Add(match.Groups["name"].Value, match.Groups["guid"].Value);
            }

            RequestInternal("stop", FirstPlayerPort);
            RequestInternal("clear", FirstPlayerPort);

            return new VideoInfo
            {
                Duration = duration,
                AudioTracks = audioTracks,
                AudioDevices = audioDevices,
                Title = title
            };
        }

        public static TimeStatus SyncTime(bool isFirstPlayerMain)
        {
            var firstPlayer = RequestInternal("get_time", FirstPlayerPort);
            var secondPlayer = RequestInternal("get_time", SecondPlayerPort);

            var firstPlayerTime = GetInteger(firstPlayer);
            var secondPlayerTime = GetInteger(secondPlayer);

            var playerTime = isFirstPlayerMain ? firstPlayerTime : secondPlayerTime;
            var difference = isFirstPlayerMain
                ? firstPlayerTime - secondPlayerTime
                : secondPlayerTime - firstPlayerTime;

            return new TimeStatus {CurrentTime = playerTime, TimeDifference = difference};
        }

        private static int GetInteger(string response)
        {
            return int.Parse(Regex
                .Match(response.Split(new[] {'\r', '\n'}, StringSplitOptions.RemoveEmptyEntries).Last(), @"\d+").Value);
        }
    }
}