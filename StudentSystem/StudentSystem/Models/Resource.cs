using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    public class Resource
    {
        [Key]
        public int ResourceId { get; set; }
        [MaxLength(50)]
        [Unicode(true)]
        public string Name { get; set; }
        [Unicode(false)]
        public string Url { get; set; }
        public enum ResourceType { Video,Presentation,Document,Other };
        public int CourseId { get; set; }

    }
}
