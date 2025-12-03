using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CrudMoura.Models;

namespace CrudMoura.Controllers
{
    
    public class FrutasController : Controller
    {
        private readonly ILogger<FrutasController> _logger;

        public static List<Fruta> listadefrutas = new List<Fruta>
        {
        
            new Fruta{Id = 1, Nome = "Morango", Preco = 5.99f, Quantidade = 10 , Categoria =  "tropical"},
            new Fruta{Id = 1, Nome = "Uva", Preco = 7.00f, Quantidade = 20,  Categoria =  "tropical"},
            new Fruta{Id = 1, Nome = "abacaxi", Preco = 4.99f, Quantidade = 1 , Categoria =  "tropical"},
        };

        public FrutasController(ILogger<FrutasController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListarFrutas()
        {
            
            
            ViewBag.frutas = listadefrutas;
            return View();
        }
        public IActionResult Create()
        {
            
            return View();
        }
     [HttpPost]
        public IActionResult SalvarFruta(Fruta frutaCadastrada)
        {
            frutaCadastrada.Id = listadefrutas.Max(f => f.Id) + 1;
            listadefrutas.Add(frutaCadastrada);
            //salvar os dados da fruta na listadefrutas 
            //volta para a 
             Console.WriteLine(frutaCadastrada.Nome);
             Console.WriteLine(frutaCadastrada.Categoria);
             Console.WriteLine(frutaCadastrada.Quantidade);
             Console.WriteLine(frutaCadastrada.Preco);
            
            return RedirectToAction(nameof (SalvarFruta));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}