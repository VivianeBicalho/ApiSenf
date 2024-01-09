using APISenf.Models.BhIss.Respostas;

namespace APISenf.Services.BhIss.LoteRps
{
    public interface IConsultarLoteRpsService
    {
        Task<RespostaConsultaNfseModel?> Consultar(string? dados);
    }
}
