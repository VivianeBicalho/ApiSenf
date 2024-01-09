using System.Xml.Serialization;

namespace APISenf.Models.BhIss
{
    [Serializable()]
    public class TomadorServicoModel
    {

        [XmlElement]
        public IdentificacaoTomadorModel? IdentificacaoTomador { get; set; }

        [XmlElement]
        public string? RazaoSocial { get; set; }

        [XmlElement]
        public EnderecoModel? Endereco { get; set; }

    }
}
