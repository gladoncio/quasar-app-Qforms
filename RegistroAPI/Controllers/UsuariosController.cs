using Microsoft.AspNetCore.Mvc;
using RegistroAPI.Data;
using RegistroAPI.Models;

namespace RegistroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UsuariosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> PostUsuario(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();
            return Ok(usuario);
        }

        [HttpGet]
        public IActionResult GetUsuarios()
        {
            return Ok(_context.Usuarios.ToList());
        }
    }
}


