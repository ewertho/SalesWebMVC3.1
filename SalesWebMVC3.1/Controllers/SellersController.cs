using Microsoft.AspNetCore.Mvc;

namespace SalesWebMVC3._1.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
