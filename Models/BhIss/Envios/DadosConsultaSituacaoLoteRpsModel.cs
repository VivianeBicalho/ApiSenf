using System.Xml.Serialization;

namespace APISenf.Models.BhIss.Envios
{
    [Serializable()]
    [XmlRoot("ConsultarSituacaoLoteRpsEnvio")]
    public class DadosConsultaSituacaoLoteRpsModel
    {
        [XmlElement]
        public PrestadorModel? Prestador { get; set; }

        [XmlElement]
        public string? Protocolo { get; set; }

    }
}
