using System;
using System.Net;
using System.Xml.Serialization;
using MultiLanguageVideoPlayer.Model;

namespace MultiLanguageVideoPlayer.Helper
{
    class VlcClient
    {
        public const string FirstPlayerPort = "9090";
        public const string SecondPlayerPort = "9091";
        private const string FirstPlayerAddress = "http://localhost:" + FirstPlayerPort;
        private const string SecondPlayerAddress = "http://localhost:" + SecondPlayerPort;

        private static WebResponse RequestInternal(string command)
        {
            var request =
                (HttpWebRequest) WebRequest.Create(command);
            request.Headers.Add("Authorization",
                "Basic " + Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(":1")));
            return request.GetResponse();
        }

        public static void SeekTo(int value)
        {
            var command = "/requests/status.xml?command=seek&val=" + value;
            RequestInternal(FirstPlayerAddress + command);
            RequestInternal(SecondPlayerAddress + command);
        }

        public static void SetAudioTracks(int leftAudioTrack, int rightAudioTrack)
        {
            RequestInternal(FirstPlayerAddress + "/requests/status.xml?command=audio_track&val=" + leftAudioTrack);
            RequestInternal(SecondPlayerAddress + "/requests/status.xml?command=audio_track&val=" + rightAudioTrack);
        }

        public static void Play()
        {
            RequestInternal(FirstPlayerAddress + "/requests/status.xml?command=pl_play");
            RequestInternal(SecondPlayerAddress + "/requests/status.xml?command=pl_play");
        }

        public static void Pause()
        {
            RequestInternal(FirstPlayerAddress + "/requests/status.xml?command=pl_pause");
            RequestInternal(SecondPlayerAddress + "/requests/status.xml?command=pl_pause");
        }

        public static void Stop()
        {
            RequestInternal(FirstPlayerAddress + "/requests/status.xml?command=pl_stop");
            RequestInternal(SecondPlayerAddress + "/requests/status.xml?command=pl_stop");
        }

        public static int GetCurrentTime()
        {
            var response = RequestInternal(FirstPlayerAddress + "/requests/status.xml");

            PlaybackStatus playbackStatus = null;
            if (response.GetResponseStream() != null)
            {
                playbackStatus =
                    (PlaybackStatus) new XmlSerializer(typeof(PlaybackStatus))
                        .Deserialize(response.GetResponseStream());
            }

            return playbackStatus?.Time ?? 0;
        }
    }
}