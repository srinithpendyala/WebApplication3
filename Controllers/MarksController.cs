using Microsoft.AspNetCore.Mvc;
using WebApplication3.Data; 
using DataEntities = WebApplication3.Data.Entities;
using ViewModels = WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class MarksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MarksController(ApplicationDbContext context)
        {
            _context = context;
        }

       
        [HttpGet]
        public IActionResult Index()
        {
            var model = new List<WebApplication3.Models.SubjectMarks>
    {
        new WebApplication3.Models.SubjectMarks(),
        new WebApplication3.Models.SubjectMarks(),
        new WebApplication3.Models.SubjectMarks(),
        new WebApplication3.Models.SubjectMarks(),
        new WebApplication3.Models.SubjectMarks(),
        new WebApplication3.Models.SubjectMarks()
    };
            return View(model);
        }


        [HttpPost]
        public IActionResult SubmitMarks(List<ViewModels.SubjectMarks> marks)
        {
            if (ModelState.IsValid)
            {
                var dataEntities = marks.Select(m => new DataEntities.SubjectMarks
                {
                    Subject = m.Subject,
                    IntMaxMarks = m.IntMaxMarks,
                    IntMarks = m.IntMarks,
                    SemMaxMarks = m.SemMaxMarks,
                    SemMarks = m.SemMarks,
                    Total = m.Total
                }).ToList();

                _context.SubjectMarks.AddRange(dataEntities);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View("Index", marks);
        }
    }
}
