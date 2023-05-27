using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlataformaDeCurso.Model
{
    public class Curso
    {
        public int Id { get; set; }
        public String nomeCurso { get; set; }
        public float duracao { get; set; }
        public ICollection<Usuario> Usuarios { get; set; }
        public ICollection<Administrador> Administradors { get; set; }
    }
}