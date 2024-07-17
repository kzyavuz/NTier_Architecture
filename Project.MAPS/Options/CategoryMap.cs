using Project.ENTİTİES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAPS.Options
{
    public class CategoryMap : BaseMaps<Category>
    {
        public CategoryMap()
        {
            ToTable("Kategori");
            Property(x => x.CatagoryName).HasColumnName("Kategori Adı");
            Property(x => x.CatagoryName).HasColumnName("Açıklama");
        }
    }
}
