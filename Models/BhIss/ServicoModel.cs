using System.Xml.Serialization;

namespace APISenf.Models.BhIss
{
    [Serializable()]
    public class ServicoModel
    {

        [XmlElement]
        public ValoresModel? Valores { get; set; }

        [XmlElement]
        public string? ItemListaServico { get; set; }

        [XmlElement]
        public string? CodigoTributacaoMunicipio { get; set; }

        [XmlElement]
        public string? Discriminacao { get; set; }

        [XmlElement]
        public string? CodigoMunicipio { get; set; }

    }
}
