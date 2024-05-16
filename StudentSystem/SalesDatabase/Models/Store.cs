using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDatabase.Models
{
    public class Store
    {
        [Key]
        public int StoreId { get; set; }
        [Unicode(false)]
        [MaxLength(80)]
        public string Name { get; set; }
        public List<Sale> sales { get; set; }
    }
}
