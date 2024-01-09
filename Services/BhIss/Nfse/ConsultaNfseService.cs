using APISenf.Helpers;
using APISenf.Models.BhIss;
using APISenf.Models.BhIss.Respostas;
using NfseHomologacaoReference;

namespace APISenf.Services.BhIss.Nfse
{
    public class ConsultaNfseService: IConsultaNfseService
    {
        public async Task<RespostaConsultaNfseModel?> Consulta(string? dados)
        {

            nfseClient client = new ();

            await client.OpenAsync();

            CabecalhoModel cabecalho = new CabecalhoModel();

            ConsultarNfseResponse consultarNfseResponse = await client.ConsultarNfseAsync(cabecalho.GetXML(), dados);

            await client.CloseAsync();

            RespostaConsultaNfseModel? respostaConsultaNfse = consultarNfseResponse.outputXML.ParseXML<RespostaConsultaNfseModel>("ConsultarNfseResposta");

            if (respostaConsultaNfse != null) respostaConsultaNfse.CompNfse = respostaConsultaNfse.CompNfse.OrderBy(n => n.Nfse.InfNfse.Numero).ToArray();

            return respostaConsultaNfse;

        }
    }
}
