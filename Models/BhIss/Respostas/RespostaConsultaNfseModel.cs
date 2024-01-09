using System.Xml.Serialization;

namespace APISenf.Models.BhIss.Respostas
{
    [Serializable()]
    public class RespostaConsultaNfseModel
    {
        [XmlArray("ListaNfse")]
        [XmlArrayItem("CompNfse", typeof(CompNfseModel))]
        public CompNfseModel[]? CompNfse { get; set; }

        [XmlArray("ListaMensagemRetorno")]
        [XmlArrayItem("MensagemRetorno", typeof(MensagemRetornoModel))]
        public MensagemRetornoModel[]? MensagemRetorno { get; set; }
    }
}
