using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Week10Day1Demo_EfCore_CodeFirst.Data;
using Week10Day1Demo_EfCore_CodeFirst.Models;

namespace Week10Day1Demo_EfCore_CodeFirst.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _dbContext;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            await TestSomething();
            return View();
        }

        private async Task TestSomething()
        {
            // Get all employees earning < 5000

            var employees = await _dbContext.Employees.ToListAsync();

            foreach (var employee in employees)
            {
                if (employee.Salary < 5000)
                {
                    //...
                }
                else
                {
                    //..
                }
            }

            var employees = _dbContext.Employees.Where(employee => employee.Salary < 5000);
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
