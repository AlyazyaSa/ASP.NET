using CODEacademyCompany.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CODEacademyCompany.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentReposatory _departmentRepo;

        public DepartmentController(IDepartmentReposatory departmentrepo)
        {
            _departmentRepo = departmentrepo;
        }

        public IActionResult Index()
        {
            var deps = _departmentRepo.GetAll();
            return View(deps);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var dep = _departmentRepo.Get(id.Value);
            return View(dep);
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Department dep)
        {
            //if(dep == null)
            //{
            //    return BadRequest();
            //}
            _departmentRepo.Create(dep);

            return RedirectToAction("Index");
        }


    }
}