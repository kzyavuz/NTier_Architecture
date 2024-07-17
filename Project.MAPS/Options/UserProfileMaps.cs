using Project.ENTİTİES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAPS.Options
{
    public class UserProfileMaps : BaseMaps<AppUserProfile>
    {
        public UserProfileMaps()
        {
            ToTable("Kullanıcı Profili");
            Property(x => x.FirstName).HasColumnName("İşim");
            Property(x => x.LastName).HasColumnName("Soy İşim");
            Property(x => x.Phone).HasColumnName("Telefon");
            Property(x => x.Address).HasColumnName("Açık Adres");
        }
    }
}
