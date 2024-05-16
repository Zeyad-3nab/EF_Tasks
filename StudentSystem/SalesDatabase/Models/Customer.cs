using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDatabase.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public int CreditCardNumber { get; set; }
        [Unicode(false)]
        [MaxLength(80)]
        public string Email { get; set; }
        [Unicode(true)]
        [MaxLength(100)]
        public int Name { get; set; }
        public List<Sale> sales { get; set; }
    }
}
