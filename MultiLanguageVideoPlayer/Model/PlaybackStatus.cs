using System.Xml.Serialization;

namespace MultiLanguageVideoPlayer.Model
{
    [XmlRoot("root")]
    public class PlaybackStatus
    {
        /** Current video play time */
        [XmlElement("time")]
        public int Time { get; set; }
    }
}