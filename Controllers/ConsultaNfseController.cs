using Microsoft.AspNetCore.Mvc;
using APISenf.Helpers;
using APISenf.Models.BhIss;
using APISenf.Models.BhIss.Envios;
using APISenf.Models.BhIss.Respostas;
using APISenf.Services.BhIss.Nfse;

namespace APISenf.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ConsultaNfseController : Controller
    {
        readonly private IConsultaNfseService _consultarNfse;

        public ConsultaNfseController(IConsultaNfseService consultarNfse)
        {
            _consultarNfse = consultarNfse;
        }

        [HttpGet]
        [Route("consulta")]
        public async Task<IActionResult> Consulta(
            string cnpj,
            string inscricaoMunicipal,
            string? numeroNfse,
            string? dataInicial,
            string? dataFinal,
            string? cnpjCpfTomador)
        {

            DadosConsultaNfseModel dados = new DadosConsultaNfseModel();

            dados.Prestador = new PrestadorModel();
            dados.Prestador.Cnpj = cnpj;
            dados.Prestador.InscricaoMunicipal = inscricaoMunicipal;

            if (numeroNfse != null) 
                dados.NumeroNfse = numeroNfse;
            else
            {
                if (dataInicial != null)
                {
                    dados.PeriodoEmissao = new PeriodoEmissaoModel();
                    dados.PeriodoEmissao.DataInicial = dataInicial;

                    if (dataFinal != null) dados.PeriodoEmissao.DataFinal = dataFinal;
                }

                if (cnpjCpfTomador != null)
                {
                    dados.Tomador = new TomadorModel();
                    dados.Tomador.CpfCnpj.Cnpj = cnpjCpfTomador;
                }
            }

            RespostaConsultaNfseModel? response = await _consultarNfse.Consulta(dados.GetXML());

            return Ok(response);

        }

    }
}
