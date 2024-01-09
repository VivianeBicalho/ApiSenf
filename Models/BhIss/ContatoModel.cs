using System.Xml.Serialization;

namespace APISenf.Models.BhIss
{
    [Serializable()]
    public class ContatoModel
    {
        [XmlElement]
        public string? Telefone { get; set; }

        [XmlElement]
        public string? Email { get; set; }
    }
}
