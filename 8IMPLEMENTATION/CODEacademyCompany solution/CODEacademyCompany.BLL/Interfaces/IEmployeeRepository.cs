using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODEacademyCompany.BLL.Interfaces
{
    public interface IEmployeeRepository
    {
        IEnumerable<IEmployeeRepository> GetAll();
        IEmployeeRepository Get(int id);
        // 
        int Create(IEmployeeRepository emp);
        int Update(IEmployeeRepository emp);
        int Delete(IEmployeeRepository emp);
    }
}
