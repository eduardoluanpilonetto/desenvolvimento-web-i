using System.Diagnostics;
using CorrecaoExercicios.Models;
using Microsoft.AspNetCore.Mvc;

namespace CorrecaoExercicios.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BemVindo()
        {
            return View();
        }

        public IActionResult Saudacao()
        {
            ViewBag.Nome = "Pedro";
            return View();
        }

        public IActionResult Cliente()
        {
            var cliente = new Cliente
            {
                Id = 1,
                Nome = "Mariana Costa",
                Email = "mariana.costa@example.com"
            };

            return View(cliente);
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
}
