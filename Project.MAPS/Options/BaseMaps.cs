using Project.ENTİTİES.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAPS.Options
{
    public abstract class BaseMaps<T> : EntityTypeConfiguration<T> where T : BaseEntity
    {
        public BaseMaps()
        {
            Property(x => x.CreateDate).HasColumnName("Oluşturulma Tarihi");
            Property(x => x.UpdateDate).HasColumnName("Güncellenme Tarihi");
            Property(x => x.DeleteDate).HasColumnName("Silinme Tarihi");
            Property(x => x.Status).HasColumnName("Veri Durumu");
        }
    }
}
