using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CrudMoura.Models;

namespace CrudMoura.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
//acao padrao inicial 
    public IActionResult Index()
    {
        return View();
    }

public IActionResult ListaNomes()
{
    string[] nomes = {"bella"," nick", "daik"};
        ViewBag.Teste =  "olá, eu vim através da viewbag";
        ViewBag.nomes =  nomes;//guarda os nomes na viewbag
  return View();//chama a view pASSANDO OS DADOS
}
public IActionResult MinhaAcao()
{
  return View();
}
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
