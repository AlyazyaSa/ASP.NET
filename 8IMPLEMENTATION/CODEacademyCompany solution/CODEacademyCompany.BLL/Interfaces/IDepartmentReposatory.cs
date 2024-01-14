using CODEacademyCompany.BLL.Reposatory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODEacademyCompany.BLL.Interfaces
{
    public interface IDepartmentReposatory
    {
        // 5 actions ==> Get All , get , create ,  delete, update
        IEnumerable<DepartmentRepository> GetAll();
        DepartmentRepository Get(int id);
        // 
        int Create(DepartmentRepository dep);
        int Update(DepartmentRepository dep);
        int Delete(DepartmentRepository dep);
    }
}
/*
    create(){

    modelstate is valid
    _context.Departmenrt.add(dep)
    _context.SaveChanges() ==> NUmber of Rows Affected in Database 
 
 
 
 */