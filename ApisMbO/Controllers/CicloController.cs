using AcessoDadosMbO.DAL;
using AcessoDadosMbO.Data;
using AcessoDadosMbO.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApisMbO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CicloController : ControllerBase
    {
        private readonly CicloDao cicloDao;

        public CicloController(ObjetivoContext context)
        {
            cicloDao = new CicloDao(context);
        }

        [HttpGet]
        public IEnumerable<Ciclo> GetCiclos()
        {
            return cicloDao.Listar();
        }

        [HttpGet]
        [Route("{id}")]
        public Ciclo? GetCicloById(int id)
        {
            try
            {
                return cicloDao.BuscarCiclo(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro na busca do ciclo!");
            }
        }

        [HttpPost]
        public Ciclo IncluirCliclo(Ciclo ciclo)
        {
            cicloDao.Executar(ciclo, TipoOperacao.Added);
            return ciclo;
        }

        [HttpPut]
        public Ciclo EditarCiclo(Ciclo ciclo)
        {

            cicloDao.Executar(ciclo, TipoOperacao.Modified);
            return ciclo;
        }

        [HttpDelete]
        public bool ExcluirUsuario(Ciclo ciclo)
        {
            try
            {
                cicloDao.Executar(ciclo, TipoOperacao.Deleted);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
