using APISenf.Models.BhIss.Respostas;

namespace APISenf.Services.BhIss.NfsePorRps
{
    public interface IConsultarNfsePorRpsService
    {
        Task<RespostaConsultaNfsePorRpsModel?> Consultar(string? dados);
    }
}
