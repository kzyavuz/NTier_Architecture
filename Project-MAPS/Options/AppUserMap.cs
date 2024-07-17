using Project_ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_MAPS.Options
{
    public class AppUserMap : BaseMaps<AppUser>
    {
        public AppUserMap()
        {
            ToTable("Kullanicilar");
            Property(x => x.UserName).HasColumnName("KullaniciAdi");
            Property(x => x.Password).HasColumnName("Sifre");
            HasOptional(x => x.AppUserProfile).WithRequired(x => x.AppUser);

        }
    }
}
