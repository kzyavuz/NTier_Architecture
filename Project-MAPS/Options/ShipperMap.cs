using Project_ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_MAPS.Options
{
    public class ShipperMap:BaseMaps<Shipper>
    {
        public ShipperMap()
        {
            ToTable("Kargocular");
            Property(x => x.CompanyName).HasColumnName("SirketAdi");
        }
    }
}
