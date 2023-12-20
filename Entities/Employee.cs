using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBContext.Entities
{
    
        public class Employee
        {
            public int EmpId { get; set; }
            public string? FirstName { get; set; }
            public string? LastName { get; set; }
            public string? Email { get; set; }
            public string? RegdNumber { get; set; }
            public string? TemporaryAddress { get; set; }
        }
   
}
