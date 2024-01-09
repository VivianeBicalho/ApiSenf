using APISenf.Models.BhIss.Envios;
using APISenf.Models.BhIss.Respostas;
using Microsoft.AspNetCore.Mvc;
using APISenf.Helpers;
using APISenf.Services.BhIss.NfsePorRps;

namespace APISenf.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConsultaNfsePorRpsController : Controller
    {
        readonly private IConsultarNfsePorRpsService _consultarNfsePorRps;

        public ConsultaNfsePorRpsController(IConsultarNfsePorRpsService consultarNfsePorRps)
        {
            _consultarNfsePorRps = consultarNfsePorRps;
        }

        [HttpGet]
        [Route("consultar-nfse-por-numeronfse")]
        public async Task<IActionResult> ConsultarNfsePorNumeroNfse(
            string cnpjPrestador,
            string inscricaoMunicipal,
            string numero,
            string serie,
            string tipo)
        {

            DadosConsultaNfsePorRpsModel dados = new DadosConsultaNfsePorRpsModel();

            dados.Prestador = new();
            dados.Prestador.Cnpj = cnpjPrestador;
            dados.Prestador.InscricaoMunicipal = inscricaoMunicipal;

            dados.IdentificacaoRps = new();
            dados.IdentificacaoRps.Numero = numero;
            dados.IdentificacaoRps.Serie = serie;
            dados.IdentificacaoRps.Tipo = tipo;

            RespostaConsultaNfsePorRpsModel? response = await _consultarNfsePorRps.Consultar(dados.GetXML());

            return Ok(response);

        }

    }

}
