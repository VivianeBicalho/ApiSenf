using System.Xml.Serialization;

namespace APISenf.Models.BhIss
{
    [Serializable()]
    public class PrestadorServicoModel
    {

        [XmlElement]
        public PrestadorModel? IdentificacaoPrestador { get; set; }

        [XmlElement]
        public string? RazaoSocial { get; set; }

        [XmlElement]
        public string? NomeFantasia { get; set; }

        [XmlElement]
        public EnderecoModel? Endereco { get; set; }

        [XmlElement]
        public ContatoModel? Contato { get; set; }
    }
}
