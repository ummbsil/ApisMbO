using AcessoDadosMbO.Data;
using AcessoDadosMbO.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDadosMbO.DAL
{
    public class UsuarioDao : GenericDao<Usuario>
    {
        public ObjetivoContext Context { get; set; }        
        public UsuarioDao(ObjetivoContext context) : base(context)
        {
            this.Context = context;
        }

        public bool GetUsuarioAutenticado(string username, string senha)
        {
            try
            {
                var usuario = Context.Usuario.Where(p => p.Email == username && p.Senha == senha).FirstOrDefault();
                return usuario == null ? false : true;
            }
            catch (Exception ex)
            {
                string e = ex.ToString();
                return false;
            }
           
        }

        public Usuario? BuscarUsuario(int id)
        {
            try
            {
                var usuario = Context.Usuario.Where(p => p.Id == id).FirstOrDefault();
                return usuario;
            }catch (Exception ex)
            {
                return null;
            }            
        }
    }
}
