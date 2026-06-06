using Microsoft.AspNetCore.Mvc;

namespace MeuPrimeiroMVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Nome = "Flávia";
            ViewBag.Curso = "Análise e Desenvolvimento de Sistemas";
            ViewBag.Semestre = "3º Semestre";

            return View();
        }

        public IActionResult Detalhes(int id)
        {
            return Content("ID do aluno: " + id);
        }
    }
}