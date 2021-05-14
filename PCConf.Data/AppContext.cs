namespace PCConf.Data
{
    using Microsoft.EntityFrameworkCore;
    using PCConf.Models;
    using PCConf.Models.Parts;

    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Nomenclature>();
            modelBuilder.Ignore<SellableItem>();
            modelBuilder.Entity<PcCaseFormat>().HasKey(sc => new { sc.PcCaseId, sc.FormatId });

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Brand> Brands { get; set; }

        public DbSet<Interface> VideoCardInterfaces { get; set; }

        public DbSet<Format> Formats { get; set; }

        public DbSet<CpuSocket> CpuSockets { get; set; }

        public DbSet<RamType> RamTypes { get; set; }

        public DbSet<VideoRamType> VideoCardRamTypes { get; set; }

        public DbSet<PcCase> PcCases { get; set; }

        public DbSet<PcCaseFormat> PcCaseFormat { get; set; }

        public DbSet<MotherBoard> MotherBoards { get; set; }

        public DbSet<PowerSuply> PowerSuplies { get; set; }

        public DbSet<Processor> Processors { get; set; }

        public DbSet<Ram> Rams { get; set; }

        public DbSet<VideoCard> VideoCards { get; set; }

        public DbSet<VideoRamType> VideoRamTypes { get; set; }

        public DbSet<Certificate> Certificates { get; set; }

        public DbSet<StorageDrive> StorageDrives { get; set; }

        public DbSet<StorageDriveType> StorageDriveTypes { get; set; }
    }
}
