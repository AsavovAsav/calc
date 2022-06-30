using Microsoft.AspNetCore.Mvc;
using CalcWeb.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Rendering;
using calc;
using Microsoft.Extensions.Logging;

namespace CalcWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ActionResult Index()
        {
            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem() { Value = "Сложение", Text ="Сложение" },
                new SelectListItem() { Value = "Вычитание", Text ="Вычитание" },
                new SelectListItem() { Value = "Умножение", Text ="Умножение" },
                new SelectListItem() { Value = "Деление", Text ="Деление" },
                new SelectListItem() { Value = "Степень", Text ="Степень" },
                new SelectListItem() { Value = "Остаток от деления", Text ="Остаток от деления" }
            };
            return View();
        }

        [HttpPost]
        public ActionResult Index(
            double firstArgument,
            double secondArgument,
            string operation)
        {
            double result = 0;

            // switch из "фабрики" напрямую.
            switch (operation)
            {
                case "Сложение":
                    Addition addition = new Addition();
                    result = addition.Calculate(firstArgument, secondArgument);
                    break;

                case "Вычитание":
                    Subtraction subtraction = new Subtraction();
                    result = subtraction.Calculate(firstArgument, secondArgument);
                    break;

                case "Умножение":
                    Multiplication multiplication = new Multiplication();
                    result = multiplication.Calculate(firstArgument, secondArgument);
                    break;
                case "Деление":
                    Division division = new Division();
                    result = division.Calculate(firstArgument, secondArgument);
                    break;

                case "Степень":
                    Degree degree = new Degree();
                    result = degree.Calculate(firstArgument, secondArgument);
                    break;

                case "Остаток от деления":
                    Remainder remainder = new Remainder();
                    result = remainder.Calculate(firstArgument, secondArgument);
                    ViewBag.Result = result;
                    break;
            }

            ViewBag.Result = result;

            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem() { Value = "Сложение", Text ="Сложение" },
                new SelectListItem() { Value = "Вычитание", Text ="Вычитание" },
                new SelectListItem() { Value = "Умножение", Text ="Умножение" },
                new SelectListItem() { Value = "Деление", Text ="Деление" },
                new SelectListItem() { Value = "Степень", Text ="Степень" },
                new SelectListItem() { Value = "Остаток от деления", Text ="Остаток от деления" }
            };
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
}
