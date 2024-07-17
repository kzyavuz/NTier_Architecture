using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTİTİES.Models
{
    public class Product:BaseEntity
    {
        public string ProductName { get; set; }
        public string UnitPrice { get; set; }
        public int? CategoryID { get; set; } 

        public virtual Category Category { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
