using AcessoDadosMbO.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDadosMbO.Data
{
    public class ObjetivoContext : DbContext
    {
        public ObjetivoContext(DbContextOptions<ObjetivoContext> options) : base(options)
        {

        }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Ciclo> Ciclos { get; set; }
        public DbSet<Objetivo> Objetivos { get; set; }
        public DbSet<ObjetivoComum> ObjetivosComuns { get; set; }
        public DbSet<Perfil> Perfis { get; set; }
        public DbSet<RegraCiclo> RegrasCiclos { get; set; }
        public DbSet<RegraObjetivo> RegrasObjetivos { get; set; }
        public DbSet<TipoObjetivo> TiposObjetivos { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<UsuarioPerfil> UsuariosPerfis { get; set; }

        protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>().ToTable("CATEGORIA");
            modelBuilder.Entity<Ciclo>().ToTable("CICLO");

            modelBuilder.Entity<Objetivo>().ToTable("OBJETIVO")
                .Property(p => p.CicloId)
                .HasColumnName("ID_CICLO");

            modelBuilder.Entity<Objetivo>().ToTable("OBJETIVO")
                .Property(p => p.UsuarioId)
                .HasColumnName("ID_USUARIO");

            modelBuilder.Entity<Objetivo>().ToTable("OBJETIVO")
                .Property(p => p.UsuarioAprovadorId)
                .HasColumnName("ID_USUARIO_APROVADOR");

            modelBuilder.Entity<Objetivo>().ToTable("OBJETIVO")
                .Property(p => p.TipoObjetivoId)
                .HasColumnName("ID_TIPO_OBJETIVO");

            modelBuilder.Entity<Objetivo>().ToTable("OBJETIVO")
                .Property(p => p.CategoriaId)
                .HasColumnName("ID_CATEGORIA");

            modelBuilder.Entity<ObjetivoComum>().ToTable("OBJETIVO_COMUM")
                .Property(p => p.TipoObjetivoId)
                .HasColumnName("ID_TIPOOBJETIVO");

            modelBuilder.Entity<ObjetivoComum>().ToTable("OBJETIVO_COMUM")
                .Property(p => p.CategoriaId)
                .HasColumnName("ID_CATEGORIA");

            modelBuilder.Entity<Perfil>().ToTable("PERFIL");

            

            modelBuilder.Entity<RegraCiclo>().ToTable("REGRA_CICLO")
                .HasNoKey()
                .Property(p => p.RegraObjetivoId)
                .HasColumnName("ID_REGRA");

            modelBuilder.Entity<RegraCiclo>().ToTable("REGRA_CICLO")
                .HasNoKey()
                .Property(p => p.CicloId)
                .HasColumnName("ID_CICLO");

            modelBuilder.Entity<RegraObjetivo>().ToTable("REGRA_OBJETIVO")
                .Property(p => p.TipoObjetivoId)
                .HasColumnName("ID_TIPO_OBJETIVO");

            modelBuilder.Entity<TipoObjetivo>().ToTable("TIPO_OBJETIVO");

            modelBuilder.Entity<Usuario>().ToTable("USUARIO");

            modelBuilder.Entity<UsuarioPerfil>().ToTable("USUARIO_PERFIL")
                .Property(p => p.PerfilId)
                .HasColumnName("ID_PERFIL");

            modelBuilder.Entity<UsuarioPerfil>().ToTable("USUARIO_PERFIL")
                .Property(p => p.UsuarioId)
                .HasColumnName("ID_USUARIO");
        }
    }
}
