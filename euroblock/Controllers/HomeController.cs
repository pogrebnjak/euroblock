using Microsoft.AspNetCore.Mvc;

namespace EuroblockSite.Controllers
{
    public class HomeController : Controller
    {
        // Главная страница
        public IActionResult Index()
        {
            return View();
        }

        // Страница "О компании"
        public IActionResult About()
        {
            return View();
        }

        // Страница с продукцией (каталог плитки)
        public IActionResult Products()
        {
            return View();
        }

        // Страница новостей и акций
        public IActionResult News()
        {
            return View();
        }

        // Страница контактов
        public IActionResult Contact()
        {
            return View();
        }
    }
}
