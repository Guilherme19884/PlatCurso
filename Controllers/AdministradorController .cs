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
    }
}