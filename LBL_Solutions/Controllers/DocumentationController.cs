using LBL_Solutions.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace LBL_Solutions.Controllers
{
    public class DocumentationController : Controller
    {

        public IActionResult Documentation()
        {
            return View();
        }
        public IActionResult NuMaps()
        {
            //return matchingPerson;
            return View();
        }
        public IActionResult CityMarket()
        {
            return View();
        }
        public IActionResult SuperAdmin()
        {
            return View();
        }
        public IActionResult TheSecretLoveProject()
        {
            return View();
        }
    }
}
