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
    [Route("[Controller]")]
    public class AdministradorController : ControllerBase
    {

        private readonly AppContexto _context;

        public AdministradorController(AppContexto context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AdicionarAdministrador(Administrador administrador)
        {
            _context.Add(administrador);
            _context.SaveChanges();
            return Ok(administrador);
        }

        [HttpGet]
        public IActionResult ListarAdministrador()
        {
            return Ok(_context.cursos);
        }

        [HttpGet("listarCurso/{id}")]
        public IActionResult listarAdministradorPorId(int id)
        {
            var Administrador = _context.administradors.Find(id);
            if (Administrador == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(Administrador);
            }
        }

        [HttpGet("obterPorNome")]
        public IActionResult ListarPorNome(string nome)
        {
            var Administrador = _context.administradors.Where(x => x.nome.Contains(nome));
            return Ok(Administrador);
        }

        [HttpPut("atualizar/{id}")]
        public IActionResult Atualizar(int id, Administrador administrador)
        {
            var Administrador = _context.administradors.Find(id);
            if (Administrador == null)
            {
                return NotFound();
            }
            Administrador.Id = Administrador.Id;
            Administrador.nome = Administrador.nome;

            _context.administradors.Update(administrador);
            _context.SaveChanges();
            return Ok(Administrador);
        }

        [HttpDelete("deletar/{id}")]
        public IActionResult Deletar(int id)
        {
            var administradorBanco = _context.administradors.Find(id);
            if (administradorBanco == null)
            {
                return NotFound();
            }
            _context.administradors.Remove(administradorBanco);
            _context.SaveChanges();
            return NoContent();
        }
    }
}