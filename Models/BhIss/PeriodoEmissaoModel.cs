using System.Xml.Serialization;

namespace APISenf.Models.BhIss
{
    [Serializable()]
    public class PeriodoEmissaoModel
    {
        private string? dataFinal;

        [XmlElement]
        public string? DataInicial { get; set; }

        [XmlElement]
        public string? DataFinal
        {
            get 
            {
                return dataFinal;
            }
            set
            {
                if (value == null)
                    this.dataFinal = DataHoje();
                else if (value.Length == 0)
                    this.dataFinal = DataHoje();
                else
                    this.dataFinal = value;
            }
        }

        private string DataHoje()
        {
            DateTime hoje = DateTime.Now;

            string dia;
            string mes;
            string ano;

            ano = hoje.Year.ToString();
            mes = hoje.Month.ToString();
            dia = hoje.Day.ToString();

            return $"{ano}-{mes}-{dia}";
        }

    }
}
