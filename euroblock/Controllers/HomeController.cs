using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace euroblock.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Получаем список изображений начинающихся на "ad" из папки wwwroot/images
            var imagesPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images");
            var adImages = Directory.GetFiles(imagesPath, "ad*.jpg")
                                    .Select(Path.GetFileName)
                                    .ToList();

            // Устанавливаем заголовок страницы
            ViewData["Title"] = "Главная";

            // Передаём список изображений в представление
            return View(adImages);
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
   
public IActionResult Catalog()
{
    // сюда база
    return View();
}
    }
}