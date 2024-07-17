using Project.ENTİTİES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAPS.Options
{
    public class OrderMap : BaseMaps<Order>
    {
        public OrderMap()
        {
            ToTable("Sipasişler");
            Property(x => x.ShippAdress).HasColumnName("Teslim Adresi");

        }
    }
}
