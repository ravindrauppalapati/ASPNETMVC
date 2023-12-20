using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBContext.Entities
{  
        public class Grade
        {
            public int GradeId { get; set; }
            public string? GradeName { get; set; }
            public string? Section { get; set; }
            //public virtual IList<Student>? Students { get; set; }
        } 
}
