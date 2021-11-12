using Microsoft.AspNetCore.Mvc;
using SalesWebMVC3._1.Models;
using System.Collections.Generic;

namespace SalesWebMVC3._1.Controllers
{
    public class DepartamentsController : Controller
    {
        public IActionResult Index()
        {
            List<Departament> list = new List<Departament>();
            list.Add(new Departament { Id=1, Name="Eletronico" });
            list.Add(new Departament { Id=2, Name="Fashion" });
            return View(list);
        }
    }
}
