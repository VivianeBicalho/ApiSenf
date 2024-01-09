using System.Xml.Serialization;

namespace APISenf.Models.BhIss
{
    [Serializable()]
    public class EnderecoModel
    {

        [XmlElement]
        public string? Endereco { get; set; }

        [XmlElement]
        public string? Numero { get; set; }

        [XmlElement]
        public string? Complemento { get; set; }

        [XmlElement]
        public string? Bairro { get; set; }

        [XmlElement]
        public string? CodigoMunicipio { get; set; }

        [XmlElement]
        public string? Uf { get; set; }

        [XmlElement]
        public string? Cep { get; set; }
    }
}
