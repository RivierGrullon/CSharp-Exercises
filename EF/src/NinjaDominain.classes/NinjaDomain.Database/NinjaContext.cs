using Microsoft.EntityFrameworkCore;


namespace NinjaDomain.Database {
    public class NinjaContext : DbContext{
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("Data Source=elpepe.db");


        public DbSet<Ninja> Ninjas { get; set; }
        public DbSet<Clan> Clans { get; set; }
        public DbSet<NinjaEquipment> Equipment { get; set; }
    }
}