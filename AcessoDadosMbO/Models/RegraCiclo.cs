using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDadosMbO.Models
{
    [Keyless]
    public class RegraCiclo
    {
        public int RegraObjetivoId { get; set; }        
        public int CicloId { get; set; }  

    }
}
