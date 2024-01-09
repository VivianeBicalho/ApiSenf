using System.Xml.Serialization;

namespace APISenf.Models.BhIss
{
    [Serializable()]
    public class TomadorModel
    {
        [XmlElement]
        public CpfCnpjModel CpfCnpj { get; set; }

        [XmlElement]
        public string? InscricaoMunicipal { get; set; }

        public TomadorModel()
        {
            CpfCnpj = new();
        }

    }
}
