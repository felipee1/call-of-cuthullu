using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCT.CCT.DOMAIN.USERBC.Entities;

namespace CCT.CCT.INFRA.Mappings
{
    public class ConquestMap : EntityTypeConfiguration<Conquest>
    {
        public ConquestMap()
        {
            HasKey(x => x.Id);
            Property(x => x.Name_conquest).HasMaxLength(60);
            Property(x => x.Type_conquest).HasMaxLength(60);
        }
    }
}
