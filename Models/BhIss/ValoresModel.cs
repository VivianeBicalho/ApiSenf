using System.Xml.Serialization;

namespace APISenf.Models.BhIss
{
    [Serializable()]
    public class ValoresModel
    {

        [XmlElement]
        public string? ValorServicos {  get; set; }

        [XmlElement]
        public string? ValorDeducoes {  get; set; }

        [XmlElement]
        public string? ValorPis {  get; set; }

        [XmlElement]
        public string? ValorCofins {  get; set; }

        [XmlElement]
        public string? ValorInss {  get; set; }

        [XmlElement]
        public string? ValorIr {  get; set; }

        [XmlElement]
        public string? ValorCsll {  get; set; }

        [XmlElement]
        public string? IssRetido {  get; set; }

        [XmlElement]
        public string? ValorIss {  get; set; }

        [XmlElement]
        public string? ValorIssRetido {  get; set; }

        [XmlElement]
        public string? OutrasRetencoes {  get; set; }

        [XmlElement]
        public string? BaseCalculo {  get; set; }

        [XmlElement]
        public string? Aliquota {  get; set; }

        [XmlElement]
        public string? ValorLiquidoNfse {  get; set; }

        [XmlElement]
        public string? DescontoIncondicionado {  get; set; }

        [XmlElement]
        public string? DescontoCondicionado {  get; set; }

    }
}
