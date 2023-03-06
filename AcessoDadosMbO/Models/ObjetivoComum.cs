using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDadosMbO.Models
{
    public class ObjetivoComum
    {
        public int Id { get; set; } 
        public int TipoObjetivoId { get; set; }  
        public int CategoriaId { get; set;}
        public string? Descricao { get; set; }  
        public float Peso { get; set; } 
        public DateTime DataImplantacao { get; set; }   
        public string? Meta { get; set; }   
        public string? Metrica{ get; set;}
    }
}
