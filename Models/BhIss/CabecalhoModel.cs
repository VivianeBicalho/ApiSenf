using System.Xml.Serialization;

namespace APISenf.Models.BhIss
{
    [Serializable()]
    [XmlRoot("cabecalho")]
    public class CabecalhoModel
    {
        [XmlAttribute("versao")]
        public string Versao { get; set; }

        [XmlElement("versaoDados")]
        public string VersaoDados { get; set; }

        public CabecalhoModel()
        {
            Versao = "1.00";
            VersaoDados = "1.00";
        }

    }
}
