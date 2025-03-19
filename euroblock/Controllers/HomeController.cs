using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using euroblock.Models;

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
            // Передаем список товаров в представление
            return View(_products);
        }

        private static List<Product> _products = new List<Product>
{
    new Product
    {
        Id = 1,
        Title = "Тротуарная плитка «Антик»",
        Description = "Описание плитки «Антик»: особенности, применение и т.д.",
        Price = 880,
        ImagePath = "product1.jpg"
    },
    new Product
    {
        Id = 2,
        Title = "Тротуарная плитка «Новый город»",
        Description = "Описание плитки «Новый город»: особенности, применение и т.д.",
        Price = 880,
        ImagePath = "product2.jpg"
    },
    new Product
    {
        Id = 3,
        Title = "Тротуарная плитка «Кирпичик»",
        Description = "Описание плитки «Кирпичик»: особенности, применение и т.д.",
        Price = 880,
        ImagePath = "product3.jpg"
    }
    // при необходимости добавляйте больше товаров
};
        public IActionResult ProductDetails(int id)
        {
            // Ищем товар по id
            var product = _products.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                // Можно вернуть ошибку или редирект на список
                return NotFound();
            }

            return View(product);
        }

    }
}
