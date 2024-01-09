using System.Xml.Serialization;

namespace APISenf.Models.BhIss.Envios
{
    [Serializable()]
    [XmlRoot("ConsultarNfseRpsEnvio")]
    public class DadosConsultaNfsePorRpsModel
    {

        [XmlElement]
        public IdentificacaoRpsModel? IdentificacaoRps { get; set; }

        [XmlElement]
        public PrestadorModel? Prestador { get; set; }

    }
}
