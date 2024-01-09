using System.Xml.Serialization;

namespace APISenf.Models.BhIss
{
    [Serializable()]
    public class CompNfseModel
    {
        [XmlElement]
        public NfseModel? Nfse { get; set; }

    }
}
