using System.IO;
using System.Xml.Serialization;

namespace Amba.System.Extensions.Xml
{
    public static class XmlExtensions
    {
        public static string ToXmlString<T>(this T toSerialize)
        {
            var xmlSerializer = new XmlSerializer(toSerialize.GetType());
            var textWriter = new StringWriter();
            xmlSerializer.Serialize(textWriter, toSerialize);
            return textWriter.ToString();
        }

        public static T DeserializeXmlStr<T>(string xml)
            where T : class
        {
            var serializer = new XmlSerializer(typeof(T));
            T result;

            using (TextReader reader = new StringReader(xml))
            {
                result = serializer.Deserialize(reader) as T;
            }

            return result;
        }
    }
}
