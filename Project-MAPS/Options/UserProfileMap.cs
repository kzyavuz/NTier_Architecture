using Project_ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_MAPS.Options
{
    public class UserProfileMap : BaseMaps<AppUserProfile>
    {
        public UserProfileMap()
        {
            ToTable("KullaniciProfili");
            Property(x => x.FirstName).HasColumnName("Isim");
            Property(x => x.LastName).HasColumnName("SoyIsim");
            Property(x => x.Phone).HasColumnName("Telefon");
            Property(x => x.Address).HasColumnName("AcikAdres");
        }
    }
}
