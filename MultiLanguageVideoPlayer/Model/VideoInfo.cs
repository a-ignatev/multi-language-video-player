using System.Collections.Generic;

namespace MultiLanguageVideoPlayer.Model
{
    public class VideoInfo
    {
        /** Video duration */
        public int Duration;

        /** Display names */
        public readonly List<string> AudioTracks = new List<string>();

        /** Display name -> Device GUID */
        public readonly Dictionary<string, string> AudioDevices = new Dictionary<string, string>();
    }
}