using AcessoDadosMbO.DAL;
using AcessoDadosMbO.Data;
using AcessoDadosMbO.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApisMbO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioDao usuarioDao;

        public UsuarioController(ObjetivoContext context) 
        {
            usuarioDao= new UsuarioDao(context);    
        }

        [HttpGet]
        public IEnumerable<Usuario> GetUsuarios()
        {
            return usuarioDao.Listar();
        }

        [HttpGet]
        [Route("{id}")]
        public Usuario? GetUsuariosById(int id)
        {
            try
            {
                return usuarioDao.BuscarUsuario(id);
            }catch(Exception ex)
            {
                throw new Exception("Ocorreu um erro na busca do usuário!");
            }
        }

        [HttpPost]
        public Usuario IncluirUsuario(Usuario usuario)
        {
            usuarioDao.Executar(usuario, TipoOperacao.Added);
            return usuario;
        }

        [HttpPut]
        public Usuario EditarUsuario(Usuario usuario)
        {

            usuarioDao.Executar(usuario, TipoOperacao.Modified);
            return usuario;
        }

        [HttpDelete]
        public bool ExcluirUsuario(Usuario usuario)
        {
            try { 
                usuarioDao.Executar(usuario, TipoOperacao.Deleted);
                return true;
            }catch(Exception ex) {
                return false;
            }

        }


    }
}
