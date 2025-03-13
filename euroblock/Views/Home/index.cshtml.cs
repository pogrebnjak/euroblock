using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace euroblock.Views.Home
{
    public class IndexModel : PageModel
    {
        public List<string> AdImages { get; set; }

        public void OnGet()
        {
            var imagesPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images");
            AdImages = Directory.GetFiles(imagesPath, "ad*.jpg")
                                .Select(Path.GetFileName)
                                .ToList();
        }
    }
}