using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    public class HomeWork
    {
        [Key]
        public int HomeworkId { get; set; }
        [Unicode(false)]
        public string Content { get; set; }
        public enum ContentType { Application,Pdf,Zip }
        public TimeOnly SubmissionTime { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }


    }
}
