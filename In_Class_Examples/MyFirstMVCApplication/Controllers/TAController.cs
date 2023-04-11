using Microsoft.AspNetCore.Mvc;

namespace MyFirstMVCApplication.Controllers
{
    public class TAController : Controller
    {
        public IActionResult Index()
        {
            List<string> tas = new List<string>();
            tas.Add("Connor");
            tas.Add("Matt");
            tas.Add("Hailey");
            tas.Add("Boone");

            return View(tas);
        }
    }
}
