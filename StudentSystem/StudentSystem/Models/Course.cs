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
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [Unicode(true)]
        [MaxLength(80)]
        public string Name { get; set; }
        [Unicode(true)]
        [AllowNull]
        public string Description { get; set; } 
        public DateOnly StarDate { get; set; }
        public DateOnly EndDate { get; set; }
        public double Price { get; set; }

        public List<Student> Students { get; set; }
        public List<Resource> Resources { get; set; }
        public List<HomeWork> HomeWorks { get; set; }

    }
}
