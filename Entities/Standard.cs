﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBContext.Entities
{
    public class Standard
    {
        public int StandardId { get; set; }
        public string? StandardName { get; set; }
        public string? Description { get; set; }
        public ICollection<Student>? Students { get; set; }
    }
}
