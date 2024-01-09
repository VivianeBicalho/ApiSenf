using APISenf.Models.BhIss.Respostas;

namespace APISenf.Services.BhIss.LoteRps
{
    public interface IConsultarSituacaoLoteRpsService
    {
        Task<RespostaConsultaSituacaoLoteRpsModel?> Consultar(string? dados);
    }
}
