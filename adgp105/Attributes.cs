using System;
using System.Collections.Generic;
using System.Collections;
using System.Xml.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace adgp105
{
    class Attributes : Hashtable, IXmlSerializable
    {
        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            reader.Read();
            reader.ReadStartElement(ToString());

            while (reader.NodeType != XmlNodeType.EndElement)
            {
                string key = reader.ReadElementContentAsString("Key",)
            }
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteStartElement(ToString());

            foreach (DictionaryEntry att in this)
            {
                writer.WriteStartElement("Item");
                writer.WriteElementString("Key", att.Key.ToString());
                writer.WriteElementString("Value", att.Value.ToString());
                writer.WriteEndElement();
            }

            writer.WriteEndElement();
        }
    }
}
