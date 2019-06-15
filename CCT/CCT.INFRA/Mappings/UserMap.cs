using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCT.CCT.DOMAIN.USERBC.Entities;

namespace CCT.CCT.INFRA.Mappings
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            HasKey(x => x.Id);
            Property(x => x.FirstName).HasMaxLength(60);
            Property(x => x.LastName).HasMaxLength(60);
            Property(x => x.Nickname).HasMaxLength(60);
            Property(x => x.Email_user).IsRequired();
            Property(x => x.Password).IsRequired().HasMaxLength(20).IsFixedLength();
            HasIndex(x => x.conquest);
        }
    }
}
