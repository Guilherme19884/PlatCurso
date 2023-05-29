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
    public class UsuarioController : ControllerBase
    {
        private readonly AppContexto _context;

        public UsuarioController(AppContexto context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AdicionarAdministrador(Usuario usuario)
        {
            _context.Add(usuario);
            _context.SaveChanges();
            return Ok(usuario);
        }

        [HttpGet]
        public IActionResult ListarUsuario()
        {
            return Ok(_context.cursos);
        }

        [HttpGet("listarCurso/{id}")]
        public IActionResult listarUsuarioPorId(int id)
        {
            var Usuario = _context.usuarios.Find(id);
            if (Usuario == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(Usuario);
            }
        }

        [HttpGet("obterPorNome")]
        public IActionResult ListarPorNome(string nome)
        {
            var Usuario = _context.administradors.Where(x => x.nome.Contains(nome));
            return Ok(Usuario);
        }

        [HttpPut("atualizar/{id}")]
        public IActionResult Atualizar(int id, Usuario usuario)
        {
            var Usuario = _context.usuarios.Find(id);
            if (Usuario == null)
            {
                return NotFound();
            }
            Usuario.Id = Usuario.Id;
            Usuario.nome = Usuario.nome;

            _context.usuarios.Update(usuario);
            _context.SaveChanges();
            return Ok(Usuario);
        }

        [HttpDelete("deletar/{id}")]
        public IActionResult Deletar(int id)
        {
            var usuarioBanco = _context.usuarios.Find(id);
            if (usuarioBanco == null)
            {
                return NotFound();
            }
            _context.usuarios.Remove(usuarioBanco);
            _context.SaveChanges();
            return NoContent();
        }
    }
}