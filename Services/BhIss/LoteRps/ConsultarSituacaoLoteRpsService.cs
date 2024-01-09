using APISenf.Models.BhIss;
using APISenf.Helpers;
using APISenf.Models.BhIss.Respostas;
using NfseHomologacaoReference;

namespace APISenf.Services.BhIss.LoteRps
{
    public class ConsultarSituacaoLoteRpsService: IConsultarSituacaoLoteRpsService
    {
        public async Task<RespostaConsultaSituacaoLoteRpsModel?> Consultar(string? dados)
        {

            nfseClient client = new();

            await client.OpenAsync();

            CabecalhoModel cabecalho = new CabecalhoModel();

            ConsultarSituacaoLoteRpsResponse consultarSituacaoLoteRpsResponse = await client.ConsultarSituacaoLoteRpsAsync(cabecalho.GetXML(), dados);

            await client.CloseAsync();

            return consultarSituacaoLoteRpsResponse.outputXML.ParseXML<RespostaConsultaSituacaoLoteRpsModel>("ConsultarSituacaoLoteRpsResposta");
        }
    }
}
