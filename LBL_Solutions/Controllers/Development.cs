using Microsoft.AspNetCore.Mvc;

namespace LBL_Solutions.Controllers
{
    public class Development : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
