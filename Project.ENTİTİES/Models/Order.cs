using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTİTİES.Models
{
    public class Order: BaseEntity
    {
        public string ShippAdress { get; set; }
        public int ShipperID { get; set; }
        public int AppUserID { get; set; }

        public virtual AppUser AppUser { get; set; }

        public virtual List<OrderDetail> OrderDetail { get; set;}

        public virtual Shipper Shipper { get; set; }
    }
}
