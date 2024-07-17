using Project.ENTİTİES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAPS.Options
{
    public class ShipperMap:BaseMaps<Shipper>
    {
        public ShipperMap()
        {
            ToTable("Kargocular");
            Property(x => x.CompanyName).HasColumnName("Şirket İşmi");
        }
    }
}
