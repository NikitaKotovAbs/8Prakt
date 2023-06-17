using System.IO;
using System.Xml.Serialization;

namespace SerializationLibrary
{
        public class DataSerializer
        {
            public void Serialize<T>(T data, string filePath)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));

                using (FileStream stream = new FileStream(filePath, FileMode.Create))
                {
                    serializer.Serialize(stream, data);
                }
            }

            public T Deserialize<T>(string filePath)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));

                using (FileStream stream = new FileStream(filePath, FileMode.Open))
                {
                    return (T)serializer.Deserialize(stream);
                }
            }
        }
    
}