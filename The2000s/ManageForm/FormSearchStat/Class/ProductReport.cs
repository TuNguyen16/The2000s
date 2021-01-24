using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The2000s.ManageForm.FormSearchStat.Class
{
    public class ProductReport
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Amount { get; set; }
        public ProductReport() { }
        public ProductReport(int id, string name, int sl)
        {
            ProductID = id;
            ProductName = name;
            Amount = sl;
        }
    }
}
