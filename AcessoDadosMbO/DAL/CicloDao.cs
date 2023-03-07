using AcessoDadosMbO.Data;
using AcessoDadosMbO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDadosMbO.DAL
{
    public class CicloDao : GenericDao<Ciclo>
    {
        public ObjetivoContext Context { get; set; }

        public CicloDao(ObjetivoContext context) : base(context)
        {
            this.Context = context;   
        }


        public Ciclo? BuscarCiclo(int id)
        {
            try
            {
                var ciclo = Context.Ciclo.Where(p => p.Id == id).FirstOrDefault();
                return ciclo;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
