using System.Xml.Serialization;

namespace APISenf.Models.BhIss.Respostas
{
    [Serializable()]
    public class RespostaConsultaNfsePorRpsModel
    {
        [XmlElement]
        public CompNfseModel? CompNfse { get; set; }

        [XmlArray("ListaMensagemRetorno")]
        [XmlArrayItem("MensagemRetorno", typeof(MensagemRetornoModel))]
        public MensagemRetornoModel[]? MensagemRetorno { get; set; }
    }
}
