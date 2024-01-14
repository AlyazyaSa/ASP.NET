using Microsoft.AspNetCore.Mvc;
using ToList.Data;
using ToList.Models;

namespace ToList.Controllers
{
    public class TodoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TodoController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var todo = _context.todos.ToList();

            return View(todo);
        }

        //--------------------------------------------------------------
        [HttpGet]
        public IActionResult Create()
        {
       
                return View();
        }


        [HttpPost]
        public IActionResult Create(Todo todo)
        {
            
            if (ModelState.IsValid)
            {
                _context.todos.Add(todo);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(todo);
        }
        //-----------------------------------------------------------

        public IActionResult Update(int id)
        {
            var todo = _context.todos.Find(id);
            return View(todo);

        }

        [HttpPost]
        public IActionResult update(Todo todo)
        {
            if (ModelState.IsValid)
            {
                _context.todos.Update(todo);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(todo);
        }

     
        public IActionResult Delete(int id)
        {
            var todo = _context.todos.Find(id);
            _context.todos.Remove(todo);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}