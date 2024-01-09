using System.Xml.Serialization;

namespace APISenf.Models.BhIss
{
    [Serializable()]
    public class IdentificacaoRpsModel
    {

        [XmlElement]
        public string? Numero { get; set; }

        [XmlElement]
        public string? Serie { get; set; }

        [XmlElement]
        public string? Tipo { get; set; }
    }
}
