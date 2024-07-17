using Project_ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_MAPS.Options
{
    public class CategoryMap : BaseMaps<Category>
    {
        public CategoryMap()
        {
            ToTable("Kategori");
            Property(x => x.CatagoryName).HasColumnName("KategoriAdi");
            Property(x => x.Description).HasColumnName("Aciklama");
        }
    }
}
