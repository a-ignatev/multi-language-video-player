using System.Collections.Generic;

namespace MultiLanguageVideoPlayer.Model
{
    public class VideoInfo
    {
        /** Video duration */
        public int Duration;

        /** Display names */
        public List<string> AudioTracks = new List<string>();

        public string Title;

        /** Display name -> Device GUID */
        public Dictionary<string, string> AudioDevices = new Dictionary<string, string>();
    }
}