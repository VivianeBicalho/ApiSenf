using System.Xml.Serialization;

namespace APISenf.Models.BhIss.Envios
{
    [Serializable()]
    [XmlRoot("ConsultarNfseEnvio")]
    public class DadosConsultaNfseModel
    {
        [XmlElement]
        public PrestadorModel? Prestador { get; set; }

        [XmlElement]
        public string? NumeroNfse { get; set; }

        [XmlElement]
        public PeriodoEmissaoModel? PeriodoEmissao { get; set; }

        [XmlElement]
        public TomadorModel? Tomador { get; set; }


    }
}
