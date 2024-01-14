using BLL.Interfaces;
using DAL.Context;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Reposatory
{
   public class DepartmentReposatory : GenericReposatory<Department> , IDepartmentRepository
    {
        private readonly ApplicationDbContext _context;

        public DepartmentReposatory(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }    
}
