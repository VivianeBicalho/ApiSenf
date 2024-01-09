using APISenf.Models.BhIss.Respostas;

namespace APISenf.Services.BhIss.Nfse
{
    public interface IConsultaNfseService
    {
        Task<RespostaConsultaNfseModel?> Consulta(string? dados);
    }
}
