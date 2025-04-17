using _Desafio_DEV_LEGALAI.Domains;
using _Desafio_DEV_LEGALAI.Interfaces;
using _Desafio_DEV_LEGALAI.Repositores;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _Desafio_DEV_LEGALAI.Controllers
{
    [Produces("application/json")]

    [Route("api/[controller]")]
    [ApiController]
    public class InteressesController : ControllerBase
    {
        private IInteresseRepository _interesseRepository { get; set; }
        public InteressesController()
        {
            _interesseRepository = new interesseRepository();
        }
        [HttpGet]
        public IActionResult Get()
        {
           List<InteresseDomain> listaInteresse = _interesseRepository.ListarInteresse();
            if (listaInteresse == null)
            {
                return NotFound("Nenhum interesse encontrado");
            }
            return Ok(listaInteresse);
        }
    }
}
