using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDatabase.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Unicode(false)]
        [MaxLength(50)]
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public List<Sale> sales { get; set; }
    }
}
