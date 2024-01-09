using System.Xml.Serialization;

namespace APISenf.Models.BhIss
{
    [Serializable()]
    public class OrgaoGeradorModel
    {

        [XmlElement]
        public string? CodigoMunicipio { get; set; }

        [XmlElement]
        public string? Uf { get; set; }

    }
}
