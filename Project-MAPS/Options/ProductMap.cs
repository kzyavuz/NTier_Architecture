using Project_ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_MAPS.Options
{
    public class ProductMap : BaseMaps<Product>
    {
        public ProductMap()
        {
            ToTable("Urunler");
            Property(x => x.ProductName).HasColumnName("UrunAdi");
            Property(x => x.UnitPrice).HasColumnName("UrunFiyatı").HasColumnType("money");
            Property(x => x.CategoryID).HasColumnName("KatagoriID");
        }
    }
}
