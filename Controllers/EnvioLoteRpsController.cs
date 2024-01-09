using APISenf.Models.BhIss.Respostas;
using APISenf.Services.BhIss.LoteRps;
using Microsoft.AspNetCore.Mvc;

namespace APISenf.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class EnvioLoteRpsController : Controller
    {

        readonly private IEnvioLoteRpsService _envioLoteRps;

        public EnvioLoteRpsController(IEnvioLoteRpsService envioLoteRps)
        {
            _envioLoteRps = envioLoteRps;
        }

        [HttpPost]
        [Route("envia")]
        public async Task<IActionResult> Envia(string nomeArquivoXml)
        {
            RespostaEnvioLoteRpsModel? response = await _envioLoteRps.Envia(nomeArquivoXml);

            if (response != null)
                return Ok(response);

            return BadRequest();
        }

    }
}
