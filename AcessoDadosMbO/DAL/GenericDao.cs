using AcessoDadosMbO.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDadosMbO.DAL
{
    public enum TipoOperacao
    {
        Detached = 0,
        Unchanged = 1,
        Deleted = 2,
        Modified = 3,
        Added = 4
    }
    public abstract class GenericDao<T> where T : class
    {
        private ObjetivoContext Context { get; set; }   
        public GenericDao(ObjetivoContext context)
        {
            this.Context = context;
        }

        public void Executar(T item, TipoOperacao tipo)
        {
            Context.Entry<T>(item).State = (EntityState)tipo;
            Context.SaveChanges();
        }

        public IEnumerable<T> Listar()
        {
            return Context.Set<T>().ToList();
        }
        public T? BuscarPorId(int id)
        {
            return Context.Set<T>().Find();
        }
    }
}
