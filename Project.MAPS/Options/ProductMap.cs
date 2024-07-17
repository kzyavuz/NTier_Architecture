using Project.ENTİTİES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAPS.Options
{
    internal class ProductMap : BaseMaps<Product>
    {
        public ProductMap()
        {
            ToTable("Ürünlr");
            Property(x => x.ProductName).HasColumnName("Ürün İşmi");
            Property(x => x.UnitPrice).HasColumnName("Ürün Fiyatı").HasColumnType("money");
            Property(x => x.CategoryID).HasColumnName("Katagori ID");
        }
    }
}
