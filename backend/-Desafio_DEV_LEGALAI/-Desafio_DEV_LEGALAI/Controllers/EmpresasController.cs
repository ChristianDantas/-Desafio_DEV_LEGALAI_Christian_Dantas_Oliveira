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
    public class EmpresasController : ControllerBase
    {
        private IEmpresaRepository _empresaRepository { get; set; }
        public EmpresasController()
        {
            _empresaRepository = new EmpresaRepository();
        }
        [HttpGet]
        public IActionResult Get()
        {
            List<EmpresaDomain> listaEmpresas = _empresaRepository.ListarEmpresas();
            if (listaEmpresas == null)
            {
                return NotFound("Nenhuma empresa encontrada");
            }
            return Ok(listaEmpresas);
        }
        [HttpPost]
        public IActionResult Post(EmpresaDomain novaEmpresa)
        {
            if (novaEmpresa.nomeEmpresa == null)
            {
                return BadRequest("Nome da empresa não pode ser vazio");
            }
            _empresaRepository.Cadastrar(novaEmpresa);
            return StatusCode(201);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            EmpresaDomain empresaBuscada = _empresaRepository.BuscarPorID(id);
            if (empresaBuscada == null)
            {
                return NotFound("Empresa não encontrada");
            }
            return Ok(empresaBuscada);
        }
    }
}
