using Microsoft.AspNetCore.Mvc;

namespace LBL_Solutions.Controllers
{
    public class PricesController : Controller
    {
        public IActionResult Prices()
        {
            return View();
        }
    }
}
