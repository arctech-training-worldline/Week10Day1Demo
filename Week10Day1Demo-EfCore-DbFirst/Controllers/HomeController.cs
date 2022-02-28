using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Week10Day1Demo_EfCore_DbFirst.Data;
using Week10Day1Demo_EfCore_DbFirst.Models;

namespace Week10Day1Demo_EfCore_DbFirst.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _dbContext;
        private readonly ApplicationDbContextProcedures _dbProcedures;

        public HomeController(
            ILogger<HomeController> logger, 
            ApplicationDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
            _dbProcedures = new ApplicationDbContextProcedures(dbContext);
        }

        public async Task<IActionResult> Index()
        {
            await TestSomething();
            return View();
        }

        private async Task TestSomething()
        {
            await _dbProcedures.AddOrderAsync(10, "Order 1", DateTime.Now, 0.18);

            var student = await _dbProcedures.GetStudentByRollNoAsync(101);
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
