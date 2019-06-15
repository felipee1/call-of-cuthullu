using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCT.CCT.DOMAIN.USERBC.Entities;

namespace CCT.CCT.INFRA.Mappings
{
    public class PerfilMap : EntityTypeConfiguration<Perfil>
    {
        public PerfilMap()
        {
            HasKey(x => x.Id);
            Property(x => x.Userp.Id);
            HasIndex(x => x.VisibleConquest);
        }
    }
}
