using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDadosMbO.Data
{
    public class DbInitializer
    {
        public static void Initialize(ObjetivoContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
