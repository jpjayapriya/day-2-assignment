using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            
            ViewBag.name = "jaya";
            ViewBag.usn = 91;
            ViewData.Add("java", 99);
            ViewData.Add("python", 98);

            int[] sem = new int[5];
            sem[0] = 100;
            sem[1] = 87;
            sem[2] = 78;
            sem[3] = 100;
            sem[4] = 50;
            ViewData.Add("sem_one", sem);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
