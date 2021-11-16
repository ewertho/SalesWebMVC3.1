using Microsoft.AspNetCore.Mvc;
using SalesWebMVC3._1.Models.Services;

namespace SalesWebMVC3._1.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService sellerService;
        public SellersController(SellerService sellerService)
        {
            this.sellerService = sellerService;
        }

        public IActionResult Index()
        {
            var list = sellerService.FindAll();   
            return View(list);
        }
    }
}
