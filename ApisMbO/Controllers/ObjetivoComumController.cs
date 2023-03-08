using AcessoDadosMbO.DAL;
using AcessoDadosMbO.Data;
using AcessoDadosMbO.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApisMbO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObjetivoComumController : ControllerBase
    {
        private readonly ObjetivoComumDao objComumDao;

        public ObjetivoComumController(ObjetivoContext context)
        {
            objComumDao = new ObjetivoComumDao(context);
        }

        [HttpGet]
        public IEnumerable<ObjetivoComum> GetObjetivosComuns()
        {
            return objComumDao.Listar();
        }

        [HttpGet]
        [Route("{id}")]
        public ObjetivoComum? GetObjComumById(int id)
        {
            try
            {
                return objComumDao.BuscarObjetivoComum(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro na busca do objetivo comum!");
            }
        }

        [HttpPost]
        public ObjetivoComum IncluirObjetivoComum(ObjetivoComum objComum)
        {
            objComumDao.Executar(objComum, TipoOperacao.Added);
            return objComum;
        }

        [HttpPut]
        public ObjetivoComum EditarObjetivoComum(ObjetivoComum objComum)
        {

            objComumDao.Executar(objComum, TipoOperacao.Modified);
            return objComum;
        }

        [HttpDelete]
        public bool ExcluirObjetivoComum(ObjetivoComum objComum)
        {
            try
            {
                objComumDao.Executar(objComum, TipoOperacao.Deleted);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
