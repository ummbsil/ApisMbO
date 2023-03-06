using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDadosMbO.Models
{
    public class Objetivo
    {
        public int Id { get; set; } 
        public int CicloId { get; set; }    
        public int UsuarioId { get; set;}
        public int UsuarioAprovadorId { get; set;}    
        public int TipoObjetivoId { get; set; }  
        public int CategoriaId { get; set;} 
        public string? Descricao { get; set;}    
        public DateTime DataImplantacao { get; set;}    
        public string? Meta { get; set;} 
        public string? Metrica { get; set; }
        public float Peso { get; set;}
        public float PercentualAtingimento { get; set;} 
        public int Status { get; set;}  
        public DateTime DataInclusao { get; set;}
        public DateTime DataAlteracao { get; set; }
        public DateTime DataAprovacao { get; set; }
        public string? ObservacaoApr { get; set; }
        public string? ObservacaoRep { get; set; }
    }
}
