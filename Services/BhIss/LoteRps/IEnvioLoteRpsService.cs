using APISenf.Models.BhIss.Respostas;

namespace APISenf.Services.BhIss.LoteRps
{
    public interface IEnvioLoteRpsService
    {
        Task<RespostaEnvioLoteRpsModel?> Envia(string nomeArquivoXml);
    }
}
