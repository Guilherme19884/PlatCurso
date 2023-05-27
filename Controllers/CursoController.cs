using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlataformaDeCurso.Contexto;
using PlataformaDeCurso.Model;

namespace PlataformaDeCurso.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CursoController : ControllerBase
    {
        private readonly AppContexto _context;

        public CursoController(AppContexto context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AdicionarCurso(Curso curso)
        {
            _context.Add(curso);
            _context.SaveChanges();
            return Ok(curso);
        }

        [HttpGet]
        public IActionResult ListarCurso()
        {
            return Ok(_context.cursos);
        }

        [HttpGet("listarCurso/{id}")]
        public IActionResult listarCursoPorId(int id)
        {
            var Curso = _context.cursos.Find(id);
            if (Curso == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(Curso);
            }
        }

        [HttpGet("obterPorNome")]
        public IActionResult ListarPorNome(string nome)
        {
            var Curso = _context.cursos.Where(x => x.nomeCurso.Contains(nome));
            return Ok(Curso);
        }
    }
}