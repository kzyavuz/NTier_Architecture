using Project.ENTİTİES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAPS.Options
{
    public class AppUserMap : BaseMaps<AppUser>
    {
        public AppUserMap()
        {
            ToTable("Kullanıcılar");
            Property(x => x.UserName).HasColumnName("Kullanıcı İşmi");
            Property(x => x.Password).HasColumnName("Şifre");
            HasOptional(x => x.AppUserProfile).WithRequired(x => x.AppUser);

        }
    }
}
