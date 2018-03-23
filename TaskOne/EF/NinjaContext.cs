using NinjaDomainClasses;
using System.Data.Entity;
using TaskOne.EF.Map;

namespace TaskOne.EF
{
    class NinjaContext : DbContext
    {

        public NinjaContext() : base("NinjaDbContext")
        {
            Database.SetInitializer<NinjaContext>(null);
        }
        //public DbSet<Ninja> Ninjas { get; set; }
        //public DbSet<Clan> Clans { get; set; }
        //public DbSet<NinjaEquipment> Equipment { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new NinjaMap());
            modelBuilder.Configurations.Add(new ClanMap());
            modelBuilder.Configurations.Add(new NinjaEquipmentMap());
        }
    }
}
