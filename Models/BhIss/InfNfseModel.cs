using System.Xml.Serialization;

namespace APISenf.Models.BhIss
{
    [Serializable()]
    public class InfNfseModel
    {
        [XmlAttribute]
        public string? Id { get; set; }

        [XmlElement]
        public string? Numero {  get; set; }

        [XmlElement]
        public string? CodigoVerificacao {  get; set; }

        [XmlElement]
        public string? DataEmissao {  get; set; }

        [XmlElement]
        public IdentificacaoRpsModel? IdentificacaoRps {  get; set; }

        [XmlElement]
        public string? DataEmissaoRps {  get; set; }

        [XmlElement]
        public string? NaturezaOperacao {  get; set; }

        [XmlElement]
        public string? RegimeEspecialTributacao {  get; set; }

        [XmlElement]
        public string? OptanteSimplesNacional {  get; set; }

        [XmlElement]
        public string? IncentivadorCultural {  get; set; }

        [XmlElement]
        public string? Competencia {  get; set; }

        [XmlElement]
        public string? OutrasInformacoes {  get; set; }

        [XmlElement]
        public ServicoModel? Servico {  get; set; }

        [XmlElement]
        public PrestadorServicoModel? PrestadorServico {  get; set; }

        [XmlElement]
        public TomadorServicoModel? TomadorServico { get; set; }

        [XmlElement]
        public IntermediarioServicoModel? IntermediarioServico { get; set; }

        [XmlElement]
        public OrgaoGeradorModel? OrgaoGerador { get; set; }

        [XmlElement]
        public ConstrucaoCivilModel? ConstrucaoCivil { get; set; }
    }
}
