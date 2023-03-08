using AcessoDadosMbO.Data;
using AcessoDadosMbO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDadosMbO.DAL
{
    public class ObjetivoComumDao : GenericDao<ObjetivoComum>
    {
        public ObjetivoContext Context { get; set; }

        public ObjetivoComumDao(ObjetivoContext context) : base(context)
        {
            this.Context = context;
        }

        public ObjetivoComum? BuscarObjetivoComum(int id)
        {
            try
            {
                var objComum = Context.ObjetivosComuns.Where(p => p.Id == id).FirstOrDefault();
                return objComum;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}
