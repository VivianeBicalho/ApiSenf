using System.Xml.Serialization;

namespace APISenf.Models.BhIss
{ 
    [Serializable()]
    public class IdentificacaoTomadorModel
    {

        [XmlElement]
        public CpfCnpjModel? CpfCnpj { get; set; }

        [XmlElement]
        public string? InscricaoMunicipal { get; set; }

    }
}
