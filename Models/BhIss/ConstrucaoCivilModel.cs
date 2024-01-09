using System.Xml.Serialization;

namespace APISenf.Models.BhIss
{
    [Serializable()]
    public class ConstrucaoCivilModel
    {
        [XmlElement]
        public string? CodigoObra {  get; set; }

        [XmlElement]
        public string? Art {  get; set; }
    }
}
