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
    // ���� ����
    return View();
}
    }
}