using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using youtube.Data;
using youtube.Models;
using youtube.Models.Domain;

namespace youtube.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly MVCDemoDbContext _mVCDemoDbContext;
        private Employee employee;

        public EmployeesController(MVCDemoDbContext mvcDemoDbcontext)
        {
            _mVCDemoDbContext = mvcDemoDbcontext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var employees = await _mVCDemoDbContext.Employees.ToListAsync();
            return View(employees);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddEmployeeViewModel addEmployeeViewModel)
        {
            if (ModelState.IsValid)
            {
                var employee = new Employee()
                {
                    Id = Guid.NewGuid(),
                    Name = addEmployeeViewModel.Name,
                    Email = addEmployeeViewModel.Email,
                    Salary = addEmployeeViewModel.Salary,
                    Department = addEmployeeViewModel.Department,
                    DateOfBirth = addEmployeeViewModel.DateOfBirth
                };

                await _mVCDemoDbContext.Employees.AddAsync(employee);
                await _mVCDemoDbContext.SaveChangesAsync();

                return RedirectToAction("Add");
            }

            await _mVCDemoDbContext.Employees.AddAsync(employee);
            await _mVCDemoDbContext.SaveChangesAsync();
            return View(addEmployeeViewModel);
        }

        [HttpGet]
        public async Task<IActionResult> View(Guid id)
        {
            var employee = await _mVCDemoDbContext.Employees.FirstOrDefaultAsync(x => x.Id == id);

            if (employee == null)
            {
                return NotFound();
            }

            var viewModel = new UpdateEmployeeViewModel()
            {
                Id = employee.Id,
                Name = employee.Name,
                Email = employee.Email,
                Salary = employee.Salary,
                Department = employee.Department,
                DateOfBirth = employee.DateOfBirth
            };

            return await View(viewModel);
        }

        [HttpPost]
 
        public async Task<IActionResult> Update(UpdateEmployeeViewModel model)
        {
            var employee = await _mVCDemoDbContext.Employees.FirstOrDefaultAsync(x => x.Id == model.Id);


            if (employee == null)
            {
                return NotFound();
            }

            {
                employee.Name = model.Name;
                employee.Email = model.Email;
                employee.Salary = model.Salary;
                employee.DateOfBirth = model.DateOfBirth;
                employee.Department = model.Department;

                await _mVCDemoDbContext.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(UpdateEmployeeViewModel model)
        {
            var employee = await _mVCDemoDbContext.Employees.FindAsync(model.Id);

            if (employee != null)
            {
                mvcDemoDbContext.Employees.Remove(employee);
                await mvcDemoDbContext.SaveChangesAsync();

                return RedirectToAction("Index");
            }
        }

    }
}