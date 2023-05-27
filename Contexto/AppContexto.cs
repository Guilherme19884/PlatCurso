using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlataformaDeCurso.Model;

namespace PlataformaDeCurso.Contexto
{
    public class AppContexto : DbContext
    {
        public AppContexto(DbContextOptions<AppContexto> options) : base(options)
        {

        }
        public DbSet<Administrador> administradors { get; set; }
        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<Curso> cursos { get; set; }
    }
}