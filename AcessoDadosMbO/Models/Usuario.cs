using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDadosMbO.Models
{
    public class Usuario
    {
        public int Id { get; set; } 
        public string? Nome { get; set; }    
        public string? Email{ get; set;}
        public int Status { get; set;}  
        public string? Senha { get; set; }
        public DateTime? DataCriacao{ get; set;}
    }
}
