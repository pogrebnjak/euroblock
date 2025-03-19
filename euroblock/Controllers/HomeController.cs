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
            // �������� ������ ����������� ������������ �� "ad" �� ����� wwwroot/images
            var imagesPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images");
            var adImages = Directory.GetFiles(imagesPath, "ad*.jpg")
                                    .Select(Path.GetFileName)
                                    .ToList();

            // ������������� ��������� ��������
            ViewData["Title"] = "�������";

            // ������� ������ ����������� � �������������
            return View(adImages);
        }  
            // �������� "� ��������"
        public IActionResult About()
        {
            return View();
        }
              // �������� � ���������� (������� ������)
        public IActionResult Products()
        {
            return View();
        }

        // �������� �������� � �����
        public IActionResult News()
        {
            return View();
        }

        // �������� ���������
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Catalog()
        {
            // �������� ������ ������� � �������������
            return View(_products);
        }

        private static List<Product> _products = new List<Product>
{
    new Product
    {
        Id = 1,
        Title = "���������� ������ ������",
        Description = "�������� ������ ������: �����������, ���������� � �.�.",
        Price = 880,
        ImagePath = "product1.jpg"
    },
    new Product
    {
        Id = 2,
        Title = "���������� ������ ������ �����",
        Description = "�������� ������ ������ �����: �����������, ���������� � �.�.",
        Price = 880,
        ImagePath = "product2.jpg"
    },
    new Product
    {
        Id = 3,
        Title = "���������� ������ ���������",
        Description = "�������� ������ ���������: �����������, ���������� � �.�.",
        Price = 880,
        ImagePath = "product3.jpg"
    }
    // ��� ������������� ���������� ������ �������
};
        public IActionResult ProductDetails(int id)
        {
            // ���� ����� �� id
            var product = _products.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                // ����� ������� ������ ��� �������� �� ������
                return NotFound();
            }

            return View(product);
        }

    }
}
