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

        public IActionResult Info(string name = "")
        {
            List<string> tas = new List<string>();
            tas.Add("Connor");
            tas.Add("Matt");
            tas.Add("Hailey");
            tas.Add("Boone");

            List<string> ta = tas.Where(x => x == name).ToList();

            return View(ta);
        }
        public IActionResult Deets(string id)
        {
            List<string> tas = new List<string>();
            tas.Add("Connor");
            tas.Add("Matt");
            tas.Add("Hailey");
            tas.Add("Boone");

            string ta = tas.Where(x => x == id).Single();

            return View(ta);
        }
    }
}
