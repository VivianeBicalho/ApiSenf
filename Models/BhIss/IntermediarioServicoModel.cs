using System.Xml.Serialization;

namespace APISenf.Models.BhIss
{
    [Serializable()]
    public class IntermediarioServicoModel
    {

        [XmlElement]
        public string? RazaoSocial { get; set; }

        [XmlElement]
        public CpfCnpjModel? CpfCnpj { get; set; }

        [XmlElement]
        public string? InscricaoMunicipal { get; set; }
    }
}
