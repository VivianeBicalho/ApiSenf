using System.Xml.Serialization;

namespace APISenf.Models.BhIss.Respostas
{
    [Serializable()]
    public class RespostaEnvioLoteRpsModel
    {
        [XmlAttribute]
        public string? NumeroLote {  get; set; }
        public string? DataRecebimento {  get; set; }
        public string? Protocolo {  get; set; }

        [XmlArray("ListaMensagemRetorno")]
        [XmlArrayItem("MensagemRetorno", typeof(MensagemRetornoModel))]
        public MensagemRetornoModel[]? MensagemRetorno { get; set; }
    }
}
