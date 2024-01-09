using System.Xml.Serialization;

namespace APISenf.Models.BhIss.Envios
{
    [Serializable()]
    [XmlRoot("ConsultarLoteRpsEnvio")]
    public class DadosConsultaLoteRpsModel
    {
        [XmlElement]
        public PrestadorModel? Prestador { get; set; }

        [XmlElement]
        public string? Protocolo { get; set; }

    }
}
