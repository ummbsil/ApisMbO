using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDadosMbO.Models
{
    public class RegraObjetivo
    {
        public int Id { get; set; } 
        public int TipoObjetivoId { get; set; }
        public int QuantidadeMinima { get; set; }
        public int QuantidadeMaxima { get; set; }
        public Usuario? Usuario { get; set;}
        public DateTime DataInclusao { get; set; }

    }
}
