using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;


namespace adgp105
{
    public static class MySerialize
    {
      

        /// <summary>
        /// File Directived for files to be stored and loaded;
        /// </summary>
        public static string m_Dir;

        public static int Serialize<T>(string fileName, T data)
        { XmlSerializer serial = new XmlSerializer(typeof(T));

            if (!Directory.Exists(m_Dir))
                return -1;

            using (FileStream fs = File.Create(m_Dir + fileName + ".xml"))
            {
                

               

                serial.Serialize(fs, data);
                fs.Close();

                return 1;
            };

        }

        public static int Deserialize<T>(string fileName, out T data)
        {
            data = default(T);

            if (!Directory.Exists(m_Dir) || !File.Exists(m_Dir + fileName + ".xml"))
                return -1;

            using (FileStream fs = File.OpenRead(m_Dir + fileName + ".xml"))
            {
                XmlSerializer serial = new XmlSerializer(typeof(T));

                serial.Deserialize(fs);
                fs.Close();
                return 1;
            }



            return 0;
        }

    }
}
