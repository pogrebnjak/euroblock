using Microsoft.AspNetCore.Mvc;

namespace EuroblockSite.Controllers
{
    public class HomeController : Controller
    {
        // ������� ��������
        public IActionResult Index()
        {
            return View();
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
    }
}
