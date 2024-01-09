using APISenf.Models.BhIss;
using APISenf.Helpers;
using APISenf.Models.BhIss.Respostas;
using NfseHomologacaoReference;
using System.Xml;

namespace APISenf.Services.BhIss.LoteRps
{
    public class EnvioLoteRpsService: IEnvioLoteRpsService
    {
        public async Task<RespostaEnvioLoteRpsModel?> Envia(string nomeArquivoXml)
        {
            string? xml = await GetTextXml(nomeArquivoXml);

            if (xml != null) 
            {
                nfseClient client = new();

                await client.OpenAsync();

                CabecalhoModel cabecalho = new CabecalhoModel();

                RecepcionarLoteRpsResponse response = await client.RecepcionarLoteRpsAsync(cabecalho.GetXML(), xml);

                await client.CloseAsync();

                return response.outputXML.ParseXML<RespostaEnvioLoteRpsModel>("EnviarLoteRpsResposta");
            }

            return null;

        }

        private async Task<string?> GetTextXml(string nomeArquivoXml)
        {
            try
            {
                var m_strFilePath = nomeArquivoXml;
                string xmlStr;
                using (var http = new HttpClient())
                {
                    xmlStr = await http.GetStringAsync(m_strFilePath);
                }
                var xmlDoc = new XmlDocument();
                xmlDoc.PreserveWhitespace = true;
                xmlDoc.LoadXml(xmlStr);

                return xmlDoc.OuterXml;
            }
            catch
            {
                return null;
            }
        }
    }
}
