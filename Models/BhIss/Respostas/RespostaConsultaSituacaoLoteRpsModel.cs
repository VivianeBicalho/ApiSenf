using System.Xml.Serialization;

namespace APISenf.Models.BhIss.Respostas
{
    [Serializable()]
    [XmlRoot("ConsultarSituacaoLoteRpsResposta")]
    public class RespostaConsultaSituacaoLoteRpsModel
    {
        [XmlElement]
        public string? NumeroLote { get; set; }

        [XmlElement]
        public string? Situacao { get; set; }
    }
}
