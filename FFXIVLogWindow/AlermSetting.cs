using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FFXIVLogWindow
{
    [Serializable]
    public class AlarmSetting
    {
        public string Name;
        public string FilterString;

        public bool ExUserChat;
        public bool FC;
        public bool Say;
        public bool Shout;
        public bool Party;
        public bool Yell;
        public bool Emote;
        public bool LS1;
        public bool LS2;
        public bool LS3;
        public bool LS4;
        public bool LS5;
        public bool LS6;
        public bool LS7;
        public bool LS8;

        public string GetSettingXml()
        {
            System.Xml.Serialization.XmlSerializer serializer =
                new System.Xml.Serialization.XmlSerializer(typeof(AlarmSetting));
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            System.Xml.XmlWriterSettings xmlwritersetting = new System.Xml.XmlWriterSettings();
            xmlwritersetting.Encoding = Encoding.UTF8;
            System.Xml.XmlWriter xmlWriter = System.Xml.XmlWriter.Create(ms, xmlwritersetting);
            serializer.Serialize(xmlWriter, this);
            return Encoding.GetEncoding("utf-8").GetString(ms.ToArray());
        }

        public static AlarmSetting LoadSettingXml(string settingxml)
        {
            System.Xml.Serialization.XmlSerializer serializer =
                new System.Xml.Serialization.XmlSerializer(typeof(AlarmSetting));
            System.IO.MemoryStream ms = new System.IO.MemoryStream(Encoding.GetEncoding("utf-8").GetBytes(settingxml));
            System.Xml.XmlReaderSettings xmlreadersettings = new System.Xml.XmlReaderSettings();
            xmlreadersettings.IgnoreWhitespace = true;
            System.Xml.XmlReader xmlReader = System.Xml.XmlReader.Create(ms, xmlreadersettings);

            return (AlarmSetting)serializer.Deserialize(xmlReader);
        }
    }
}
