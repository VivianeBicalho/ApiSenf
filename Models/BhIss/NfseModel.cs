using System.Xml.Serialization;

namespace APISenf.Models.BhIss
{
    [Serializable()]
    public class NfseModel
    {

        [XmlElement]
        public InfNfseModel? InfNfse { get; set; }

    }
}
