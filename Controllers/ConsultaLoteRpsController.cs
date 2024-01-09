using APISenf.Helpers;
using APISenf.Models.BhIss;
using Microsoft.AspNetCore.Mvc;
using APISenf.Models.BhIss.Envios;
using APISenf.Models.BhIss.Respostas;
using APISenf.Services.BhIss.LoteRps;

namespace APISenf.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConsultaLoteRpsController : Controller
    {
        readonly private IConsultarLoteRpsService _consultarLoteRps;
        readonly private IConsultarSituacaoLoteRpsService _consultarSituacaoLoteRps;

        public ConsultaLoteRpsController(IConsultarLoteRpsService consultarLoteRps, IConsultarSituacaoLoteRpsService consultarSituacaoLoteRps)
        {
            _consultarLoteRps = consultarLoteRps;
            _consultarSituacaoLoteRps = consultarSituacaoLoteRps;
        }

        [HttpGet]
        [Route("consultar-lote-rps-por-protocolo")]
        public async Task<IActionResult> ConsultarLoteRpsPorProtocolo(
                    string cnpjPrestador,
                    string inscricaoMunicipal,
                    string protocolo)
        {

            DadosConsultaLoteRpsModel dados = new DadosConsultaLoteRpsModel();

            dados.Prestador = new PrestadorModel();
            dados.Prestador.Cnpj = cnpjPrestador;
            dados.Prestador.InscricaoMunicipal = inscricaoMunicipal;

            dados.Protocolo = protocolo;

            RespostaConsultaNfseModel? response = await _consultarLoteRps.Consultar(dados.GetXML());

            return Ok(response);

        }

        [HttpGet]
        [Route("consultar-situacao-lote-rps")]
        public async Task<IActionResult> ConsultarSituacaoLoteRps(
                    string cnpjPrestador,
                    string inscricaoMunicipal,
                    string protocolo)
        {

            DadosConsultaSituacaoLoteRpsModel dados = new DadosConsultaSituacaoLoteRpsModel();

            dados.Prestador = new PrestadorModel();
            dados.Prestador.Cnpj = cnpjPrestador;
            dados.Prestador.InscricaoMunicipal = inscricaoMunicipal;

            dados.Protocolo = protocolo;

            RespostaConsultaSituacaoLoteRpsModel? response = await _consultarSituacaoLoteRps.Consultar(dados.GetXML());

            return Ok(response);

        }

    }
}
