using System;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;
using System.Xml.Serialization;
using MultiLanguageVideoPlayer.Model;

namespace MultiLanguageVideoPlayer.Helpers
{
    internal static class VlcClient
    {
        public const string FirstPlayerPort = "9090";
        public const string SecondPlayerPort = "9091";
        private const string FirstPlayerAddress = "http://localhost:" + FirstPlayerPort;
        private const string SecondPlayerAddress = "http://localhost:" + SecondPlayerPort;

        private static WebResponse RequestInternal(string command)
        {
            try
            {
                var request = (HttpWebRequest) WebRequest.Create(command);
                request.Headers.Add("Authorization",
                    "Basic " + Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(":1")));

                return request.GetResponse();
            }
            catch (Exception e)
            {
                // todo add some logic
                Trace.WriteLine(e.Message);
                return null;
            }
        }

        public static void SeekTo(int value)
        {
            Trace.WriteLine("Seek To: " + value);

            var command = "/requests/status.xml?command=seek&val=" + value;
            RequestInternal(FirstPlayerAddress + command);
            RequestInternal(SecondPlayerAddress + command);
        }

        public static void SetAudioTracks(int leftAudioTrack, int rightAudioTrack)
        {
            Trace.WriteLine("SetAudioTracks: " + leftAudioTrack + ", " + rightAudioTrack);

            RequestInternal(FirstPlayerAddress + "/requests/status.xml?command=audio_track&val=" + leftAudioTrack);
            RequestInternal(SecondPlayerAddress + "/requests/status.xml?command=audio_track&val=" + rightAudioTrack);
        }

        public static void Play()
        {
            Trace.WriteLine("Play");

            RequestInternal(FirstPlayerAddress + "/requests/status.xml?command=pl_play");
            RequestInternal(SecondPlayerAddress + "/requests/status.xml?command=pl_play");
        }

        public static void Pause()
        {
            Trace.WriteLine("Pause");

            RequestInternal(FirstPlayerAddress + "/requests/status.xml?command=pl_pause");
            RequestInternal(SecondPlayerAddress + "/requests/status.xml?command=pl_pause");
        }

        public static void Stop()
        {
            Trace.WriteLine("Stop");

            RequestInternal(FirstPlayerAddress + "/requests/status.xml?command=pl_stop");
            RequestInternal(SecondPlayerAddress + "/requests/status.xml?command=pl_stop");
        }

        public static void AddFile(string filePath, bool showVideoForLeft)
        {
            Trace.WriteLine("AddFile: " + filePath);

            var playCommand = $"/requests/status.xml?command=in_play&input={filePath}";
            RequestInternal(FirstPlayerAddress + (showVideoForLeft ? playCommand : playCommand + "&option=novideo"));
            RequestInternal(SecondPlayerAddress + (showVideoForLeft ? playCommand + "&option=novideo" : playCommand));
        }

        public static TimeStatus SyncTime(bool isFirstPlayerMain)
        {
            var firstPlayer = RequestInternal(FirstPlayerAddress + "/requests/status.xml");
            var secondPlayer = RequestInternal(SecondPlayerAddress + "/requests/status.xml");

            var firstPlayerTime = GetTimeFromResponse(firstPlayer);
            var secondPlayerTime = GetTimeFromResponse(secondPlayer);

            var playerTime = isFirstPlayerMain ? firstPlayerTime : secondPlayerTime;
            var difference = isFirstPlayerMain ? firstPlayerTime - secondPlayerTime : secondPlayerTime - firstPlayerTime;

            return new TimeStatus {CurrentTime = playerTime, TimeDifference = difference};
        }

        private static int GetTimeFromResponse(WebResponse response)
        {
            if (response == null)
                return 0;

            var responseStream = response.GetResponseStream();
            PlaybackStatus playbackStatus = null;

            if (responseStream != null)
            {
                playbackStatus =
                    (PlaybackStatus) new XmlSerializer(typeof(PlaybackStatus))
                        .Deserialize(responseStream);
            }

            return playbackStatus?.Time ?? 0;
        }
    }
}