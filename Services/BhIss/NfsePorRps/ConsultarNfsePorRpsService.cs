using APISenf.Models.BhIss.Respostas;
using APISenf.Models.BhIss;
using APISenf.Helpers;
using NfseHomologacaoReference;

namespace APISenf.Services.BhIss.NfsePorRps
{
    public class ConsultarNfsePorRpsService : IConsultarNfsePorRpsService
    {
        public async Task<RespostaConsultaNfsePorRpsModel?> Consultar(string? dados)
        {

            nfseClient client = new();

            await client.OpenAsync();

            CabecalhoModel cabecalho = new CabecalhoModel();

            ConsultarNfsePorRpsResponse consultarNfseResponse = await client.ConsultarNfsePorRpsAsync(cabecalho.GetXML(), dados);

            await client.CloseAsync();

            return consultarNfseResponse.outputXML.ParseXML<RespostaConsultaNfsePorRpsModel>("ConsultarNfseRpsResposta");

        }
    }
}
