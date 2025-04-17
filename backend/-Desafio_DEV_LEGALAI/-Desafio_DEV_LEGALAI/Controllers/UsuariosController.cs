using _Desafio_DEV_LEGALAI.Interfaces;
using _Desafio_DEV_LEGALAI.Repositores;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _Desafio_DEV_LEGALAI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository { get; set; }

        public UsuariosController()
        {
            _usuarioRepository = new UsuarioRepository();
        }
        [HttpGet]
        public IActionResult Get()
        {
            List<Domains.UsuarioDomain> listaUsuario = _usuarioRepository.ListarUsuario();
            if (listaUsuario == null)
            {
                return NotFound("Nenhum usuario encontrado");
            }
            return Ok(listaUsuario);
        }
        [HttpPost]
        public IActionResult Post(Domains.UsuarioDomain novoUsuario)
        {
            if (novoUsuario.nomeUsuario == null)
            {
                return BadRequest("Nome do usuario não pode ser vazio");
            }
            _usuarioRepository.Cadastrar(novoUsuario);
            return StatusCode(201);
        }
    }
}
