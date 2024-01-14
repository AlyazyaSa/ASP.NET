using Microsoft.AspNetCore.Mvc;

namespace company.Controllers
{
    public class AboutController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
