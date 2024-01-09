using System.Xml.Serialization;

namespace APISenf.Models.BhIss
{
    [Serializable()]
    public class MensagemRetornoModel
    {
        [XmlElement]
        public string? Codigo { get; set; }

        [XmlElement]
        public string? Mensagem { get; set; }

    }
}
