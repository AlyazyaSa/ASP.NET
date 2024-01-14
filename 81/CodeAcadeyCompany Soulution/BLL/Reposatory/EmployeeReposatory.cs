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
    public class EmployeeReposatory : GenericReposatory<Employee>, IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;
        public EmployeeReposatory(ApplicationDbContext context) :base(context)
        {
            _context = context;
        }
    }
}
