using Project_ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_MAPS.Options
{
    public class OrderMap : BaseMaps<Order>
    {
        public OrderMap()
        {
            ToTable("Siparisler");
            Property(x => x.ShippAdress).HasColumnName("TeslimAdresi");

        }
    }
}
