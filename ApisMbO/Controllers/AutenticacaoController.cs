using AcessoDadosMbO.DAL;
using AcessoDadosMbO.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApisMbO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutenticacaoController : ControllerBase
    {
        private readonly UsuarioDao usuarioDao;
        public AutenticacaoController(ObjetivoContext context)
        {
            usuarioDao = new UsuarioDao(context);   
        }
        [HttpGet("{username}/{password}")]
        public bool GetAutenticacao(string username, string password)
        {
            return usuarioDao.GetUsuarioAutenticado(username, password); ; 
        }
    }
}
