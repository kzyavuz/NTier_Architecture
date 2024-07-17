using Project_ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_MAPS.Options
{
    public abstract class BaseMaps<T> : EntityTypeConfiguration<T> where T : BaseEntity
    {
        public BaseMaps()
        {
            Property(x => x.CreateDate).HasColumnName("OlusturmaTarihi");
            Property(x => x.UpdateDate).HasColumnName("GuncellenmeTarihi");
            Property(x => x.DeleteDate).HasColumnName("SilinmeTarihi");
            Property(x => x.Status).HasColumnName("VeriDurumu");
        }
    }
}
