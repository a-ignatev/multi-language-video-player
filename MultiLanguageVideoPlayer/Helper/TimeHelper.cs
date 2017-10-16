using System;

namespace MultiLanguageVideoPlayer.Helper
{
    public static class TimeHelper
    {
        /**
         * Convert time like HH:MM:SS to seconds count 
         */
        public static int StringToSeconds(string time)
        {
            DateTime datetime;
            if (DateTime.TryParse(time, out datetime))
            {
                return (int) datetime.TimeOfDay.TotalSeconds;
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