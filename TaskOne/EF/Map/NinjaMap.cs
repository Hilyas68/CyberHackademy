using NinjaDomainClasses;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne.EF.Map
{
    class NinjaMap : EntityTypeConfiguration<Ninja>
    {
        public NinjaMap()
        {
            this.Property(a => a.Name).HasMaxLength(150);
            this.Property(a => a.ServedInOniwaban);
        }
    }

    class ClanMap : EntityTypeConfiguration<Clan>
    {
        public ClanMap()
        {
            this.Property(a => a.ClanName).HasMaxLength(150);
        }
    }

    class NinjaEquipmentMap : EntityTypeConfiguration<NinjaEquipment>
    {
        public NinjaEquipmentMap()
        {
            this.Property(a => a.Name).HasMaxLength(150);
        }
    }
}
