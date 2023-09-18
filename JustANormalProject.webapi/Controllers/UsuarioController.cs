using JustANormalProject.webapi.Domains;
using JustANormalProject.webapi.Interfaces;
using JustANormalProject.webapi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JustANormalProject.webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class UsuarioController : ControllerBase
    {
        private IUsuariosRepository _usuarioRepository;

        public UsuarioController() 
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [HttpPost]
        public IActionResult Post(Usuario usuario)
        {
            try
            {
                _usuarioRepository.Cadastrar(usuario);

                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        //falta implementar
        [HttpGet]
        public IActionResult GetByEmailAndPassword()
        {
            try
            {
                
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
