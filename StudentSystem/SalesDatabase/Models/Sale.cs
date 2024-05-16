using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDatabase.Models
{
    public class Sale
    {
        [Key]
        public int SaleId { get; set; }
        public int CustomerId { get; set; }
        public DateOnly Date { get; set; }
        public int ProductId { get; set; }
        public int StoreId { get; set; }
        public Product product { get; set; }
        public Customer customer { get; set; }
        public Store store { get; set; }
    }

}
