using System.Xml.Serialization;
using APISenf.Models.BhIss;
using APISenf.Models.BhIss.Envios;
using APISenf.Models.BhIss.Respostas;

namespace APISenf.Helpers
{
    internal static class ParseHelpers
    {
        private const string _namespace = "http://www.abrasf.org.br/nfse.xsd";

        public static T? ParseXML<T>(this string @this, string Root) where T : class
        {
            T? response;
            XmlRootAttribute xmlRootAttribute = new XmlRootAttribute(Root);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T), null, null, xmlRootAttribute, _namespace);

            using (StringReader textReader = new StringReader(@this.Trim().ToString()))
            {
                response = (T?)xmlSerializer.Deserialize(textReader);
            }
            return response;
        }

        public static string? GetXML<T>(this T @this)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T), _namespace);

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, @this);
                return textWriter.ToString().Replace("<?xml version=\"1.0\" encoding=\"utf-16\"?>", "");
            }
        }

    }
}
