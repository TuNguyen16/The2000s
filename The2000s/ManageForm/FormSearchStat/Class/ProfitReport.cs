using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The2000s.ManageForm.FormSearchStat.Class
{
    public class ProfitReport
    {
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public int Total { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
