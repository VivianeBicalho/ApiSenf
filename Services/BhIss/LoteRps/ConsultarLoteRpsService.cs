using APISenf.Models.BhIss;
using APISenf.Helpers;
using APISenf.Models.BhIss.Respostas;
using NfseHomologacaoReference;

namespace APISenf.Services.BhIss.LoteRps
{
    public class ConsultarLoteRpsService: IConsultarLoteRpsService
    {
        public async Task<RespostaConsultaNfseModel?> Consultar(string? dados)
        {
            nfseClient client = new();

            await client.OpenAsync();

            CabecalhoModel cabecalho = new CabecalhoModel();

            ConsultarLoteRpsResponse consultarLoteRpsResponse = await client.ConsultarLoteRpsAsync(cabecalho.GetXML(), dados);

            await client.CloseAsync();

            return consultarLoteRpsResponse.outputXML.ParseXML<RespostaConsultaNfseModel>("ConsultarLoteRpsResposta");
        }
    }
}
