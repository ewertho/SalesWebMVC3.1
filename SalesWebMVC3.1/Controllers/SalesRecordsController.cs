using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using SalesWebMVC3._1.Models.Services;

namespace SalesWebMVC3._1.Controllers
{
    public class SalesRecordsController : Controller
    {
        public readonly SalesRecordService _salesRecordService;

        public SalesRecordsController(SalesRecordService salesRecordService)
        {
            _salesRecordService = salesRecordService;
        }


        // GET: SalesRecordsController
        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> SimpleSearch(DateTime? minDate, DateTime? maxDate)
        {
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }
            ViewData["minDate"] = minDate.Value.ToString("dd-MM-yyyy");
            ViewData["maxDate"] = maxDate.Value.ToString("dd-MM-yyyy");
            var result =  await _salesRecordService.FindBydDateAsync(minDate, maxDate);
            return View(result);
        }

        public ActionResult GroupingSearch()
        {
            return View();
        }

        
    }
}
