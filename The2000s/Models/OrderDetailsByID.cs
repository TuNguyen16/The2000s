using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The2000s.Models
{
    public class OrderDetailsByID
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string CatName { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }
        public int Total { get; set; }
    }
}
