using System;

namespace MultiLanguageVideoPlayer.Helpers
{
    public static class TimeHelper
    {
        /**
         * Convert seconds count to time format string like HH:MM:SS
         */
        public static string SecondsToString(int seconds)
        {
            return TimeSpan.FromSeconds(seconds).ToString(@"hh\:mm\:ss");
        }
    }
}