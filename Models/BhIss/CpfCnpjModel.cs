using System.Xml.Serialization;

namespace APISenf.Models.BhIss
{
    [Serializable()]
    public class CpfCnpjModel
    {
        private string? cnpj;
        private string? cpf;


        [XmlElement]
        public string? Cnpj        
        { 
            get
            {  return cnpj; }
            set
            {
                if (value == null)
                {
                    cnpj = null;
                }
                else
                {
                    if (value.Length > 0)
                    {
                        cnpj = value;
                        cpf = null;
                    }
                    else { cnpj = null; }
                }
            }

        }

        [XmlElement]
        public string? Cpf
        {
            get
            { return cpf; }
            set
            {
                if (value == null)
                {
                    cpf = null;
                }
                else
                {
                    if (value.Length > 0)
                    {
                        cpf = value;
                        cnpj = null;
                    }
                    else { cpf = null; }    
                }
            }

        }
    }
}
