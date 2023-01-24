using Microsoft.AspNetCore.Mvc;

namespace ProblemsWeb.Controllers
{
    public class SiteController : Controller
    {
        public IActionResult Search()
        {
            return View();
        }

        public IActionResult Solution()
        {
            return View();
        }

        public IActionResult User()
        {
            return View();
        }

        public IActionResult AllSlt()
        {
            return View();
        }
    }
}
