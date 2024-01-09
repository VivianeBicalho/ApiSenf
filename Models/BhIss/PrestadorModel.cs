using System.Xml.Serialization;

namespace APISenf.Models.BhIss
{
    [Serializable()]
    public class PrestadorModel
    {

        [XmlElement]
        public string? Cnpj { get; set; }

        [XmlElement]
        public string? InscricaoMunicipal { get; set; }

    }
}
