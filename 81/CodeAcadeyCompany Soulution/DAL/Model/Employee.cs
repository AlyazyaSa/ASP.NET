using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public string Email { get; set; }

    
        public int Age { get; set; }

        public double Salary { get; set; }
    }
}
