﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace DBContext.Entities
{
    public class StudentAddress
    {
        [Key]
        public int StudentId { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? Mobile { get; set; }
        public string? Email { get; set; }
        public virtual Student Student { get; set; } = null!;
    }
}
