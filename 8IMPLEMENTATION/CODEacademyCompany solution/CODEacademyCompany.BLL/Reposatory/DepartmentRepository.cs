using CODEacademyCompany.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODEacademyCompany.BLL.Reposatory
{
    public class DepartmentRepository : IDepartmentReposatory
    {
        private readonly ApplicationDbContext _context; //==> EMPTY 
        public DepartmentRepository(ApplicationDbContext context)
        {
            //_context = new ApplicationDbContext()
            _context = context; //
        }


        public int Create(DepartmentRepository dep)
        {
            _context.Departments.Add(dep);
            return _context.SaveChanges();
        }

        public int Delete(DepartmentRepository dep)
        {
            _context.Departments.Remove(dep);
            return _context.SaveChanges();
        }

        public DepartmentRepository Get(int id)
           => _context.Departments.Find(id);



        public IEnumerable<DepartmentRepository> GetAll()
             => _context.Departments.ToList();


        public int Update(DepartmentRepository dep)
        {
            _context.Departments.Update(dep);
            return _context.SaveChanges();
        }
    }
}