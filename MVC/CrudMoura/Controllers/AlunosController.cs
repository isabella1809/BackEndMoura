using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CrudMoura.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CrudMoura.Controllers
{
 
    public class AlunosController : Controller
    {
        private readonly ILogger<AlunosController> _logger;

         public static List<Aluno> listadealuno = new List<Aluno>
        {
        
            new Aluno{Id = 1, Nome = "isabella", nota = 10, Sala = 1 , CPF=  56441836666, RA= 00001118653609},
            new Aluno{Id = 1, Nome = "Daik", nota = 0, Sala = 1 , CPF=  500053513123, RA= 0000111813249},
            new Aluno{Id = 1, Nome = "nicole", nota = 8, Sala = 1 , CPF=  56441836666, RA= 00001118653232},
           
        };

        public AlunosController(ILogger<AlunosController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult create()
        {
            return View();
        }

         [HttpPost]
        // public IActionResult SalvarFruta(Aluno AlunoCadastrada)
        // {
        //     AlunoCadastrada.Id = listadealuno.Max(f => f.Id) + 1;
        //     listadealuno.Add(AlunoCadastrada);
           
        //      Console.WriteLine(AlunoCadastrada.Nome);
        //      Console.WriteLine(AlunoCadastrada.Sala);
        //      Console.WriteLine(AlunoCadastrada.nota);
            
        //     return RedirectToAction(nameof (SalvarFruta));
        // }

            [HttpPost]
       
        public IActionResult SalvarFruta(Aluno AlunoCadastrada)
        {

          
            AlunoCadastrada.Id = listadealuno.Max(f => f.Id) + 1;
            
            listadealuno.Add(AlunoCadastrada);
            
            return RedirectToAction(nameof(listadealuno));
        }
        [HttpGet]
        public IActionResult listadealunos()
        {
            ViewBag.Aluno= listadealuno;
            return View();
        }
        public IActionResult cadastrar()
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