using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DevConnectMoura.Contexts;
using DevConnectMoura.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DevConnectMoura.Controllers
{

    public class UsuarioController : Controller
    {
        private readonly DevConnectContext _context;
        private readonly ILogger<UsuarioController> _logger;

        public UsuarioController(ILogger<UsuarioController> logger, DevConnectContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.UsuarioNovoCadastrado = "";
            TempData["UsuarioNovoCadastrado"] = "";
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(IFormCollection from)
        {
            TbUsuario NovoUsuario = new TbUsuario()
            {
                NomeCompleto = from["NomeCompleto"].ToString(),
                NomeUsuario = from["NomeUsuario"].ToString(),
                Email = from["Email"].ToString(),
                Senha = from["Senha"].ToString(),

            };
            if (from.Files.Count > 0)
            {
                IFormFile file = from.Files[0];
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images");

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                string path = Path.Combine(folder, file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                NovoUsuario.FotoPerfilUrl = file.FileName;
            }
            else
            {
                NovoUsuario.FotoPerfilUrl = "";
            }

            try
            {
                _context.TbUsuario.Add(NovoUsuario);

                await _context.SaveChangesAsync();

                TempData["UsuarioNovoCadastrado"] = "Cadastrado";

                return RedirectToAction("Index", "Home");
            }
            catch (System.Exception)
            {
                ViewBag.UsuarioNovoCadastrado = "Nao cadastrado";
                TempData["UsuarioNovoCadastrado"] = "";
                throw;
            }

        }
        public IActionResult Perfil()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}