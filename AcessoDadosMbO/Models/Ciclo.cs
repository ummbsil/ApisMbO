using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDadosMbO.Models
{
    public class Ciclo
    {
        public int Id { get; set; }
        public int Ano { get; set; }    
        public int Codigo { get; set; }
        public string? Descricao { get; set; }   
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int CicloFinal { get; set; }
    }
}
