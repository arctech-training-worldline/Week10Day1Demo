using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Week10Day1Demo_EfCore.Data;
using Week10Day1Demo_EfCore.Models;

namespace Week10Day1Demo_EfCore.Controllers
{
    public class StudentsController : Controller
    {
        //private readonly IStudentsService _studentsService;
        //public StudentsController(IStudentsService studentsService)
        //{
        //    _studentsService = studentsService;
        //}

        private readonly ApplicationDbContext _dbContext;
        public StudentsController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            //var students = await _studentsService.GetAllStudentsAsync();
            var students = await _dbContext.Students.ToListAsync();

            return View(students);
        }

        /// <summary>
        /// Just a test method to show how to implement EF Core for a new Entity/Table
        /// </summary>
        /// <returns></returns>
        private async Task TestOrders()
        {

            await _dbContext.Orders.AddAsync(new Order
            { OrderId = 101, OrderTitle = "TEst Order 1", OrderDate = DateTime.Now });

            await _dbContext.Orders.AddAsync(new Order
            { OrderId = 102, OrderTitle = "TEst Order 2", OrderDate = DateTime.Now.AddHours(-5) });

            await _dbContext.Orders.AddAsync(new Order
            { OrderId = 103, OrderTitle = "TEst Order 3", OrderDate = DateTime.Now.AddHours(-7), StateTax = 0.18 });

            await _dbContext.SaveChangesAsync();
        }

        // Get
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Student student)
        {
            if (!ModelState.IsValid)
                return View();

            //await _studentsService.InsertAsync(student);
            await _dbContext.Students.AddAsync(student);
            await _dbContext.SaveChangesAsync();

            TempData["success-msg"] = "Student has been successfully created!!";

            return RedirectToAction("Index");
        }

        // Get
        public async Task<IActionResult> Edit(int rollNo)
        {
            //var studentFromDb = await _studentsService.Find(rollNo);

            var studentFromDb = await _dbContext.Students.FindAsync(rollNo);

            if (studentFromDb == null)
                return NotFound();

            return View(studentFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Student student)
        {
            if (!ModelState.IsValid)
                return View();

            //await _studentsService.UpdateAsync(student);
            _dbContext.Students.Update(student);
            await _dbContext.SaveChangesAsync();

            TempData["success-msg"] = "Student has been successfully updated!!";

            return RedirectToAction("Index");
        }

        // Get
        public async Task<IActionResult> Delete(int rollNo)
        {
            //await _studentsService.DeleteAsync(rollNo);

            var studentFromDb = await _dbContext.Students.FindAsync(rollNo);

            _dbContext.Students.Remove(studentFromDb);

            return RedirectToAction("Index");
        }
    }
}
