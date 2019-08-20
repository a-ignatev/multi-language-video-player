using System;

namespace MultiLanguageVideoPlayer.Helpers
{
    public static class TimeHelper
    {
        /**
         * Convert time like HH:MM:SS to seconds count 
         */
        public static int StringToSeconds(string time)
        {
            if (TimeSpan.TryParse(time, out var duration))
            {
                return (int)duration.TotalSeconds;
            }

            return 0;
        }

        /**
         * Convert seconds count to time format string like HH:MM:SS
         */
        public static string SecondsToString(int seconds)
        {
            return TimeSpan.FromSeconds(seconds).ToString(@"hh\:mm\:ss");
        }
    }
}