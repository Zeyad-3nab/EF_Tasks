using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Unicode(true)]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(10)]
        [MinLength(10)]
        [Unicode(false)]
        [AllowNull]
        public string Phone { get; set; }
        public DateTime RegisteredOn { get; set; }

        [AllowNull]
        public DateOnly BirthDay { get; set; } 
        public List<Course> courses { get; set; }
        public List<HomeWork> homeWorks { get; set; }


    }
}
