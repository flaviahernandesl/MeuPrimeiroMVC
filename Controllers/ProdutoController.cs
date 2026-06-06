using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MeuPrimeiroMVC.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            List<string> produtos = new List<string>
            {
                "Teclado",
                "Mouse",
                "Monitor",
                "Notebook",
                "Fone"
            };

            List<double> precos = new List<double>
            {
                120.00,
                80.50,
                900.00,
                3500.00,
                150.00
            };

            ViewBag.Produtos = produtos;
            ViewBag.Precos = precos;

            return View();
        }
    }
}