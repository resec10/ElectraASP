using Microsoft.EntityFrameworkCore;

namespace ElectraASP.Models
{
    public class ThisContext : DbContext
    {
        public DbSet<Computer> Computers { get; set; }
        public DbSet<Case> Cases { get; set; }
        public DbSet<Cooler> Coolers { get; set; }
        public DbSet<CPU> CPU_Table { get; set; }
        public DbSet<Motherboard> Motherboards { get; set; }
        public DbSet<Power> Powers { get; set; }
        public DbSet<RAM> RAM_Table { get; set; }
        public DbSet<SSD> SSD_Table { get; set; }
        public DbSet<VideoCard> VideoCards { get; set; }
        public DbSet<Part> ToBeBought { get; set; }
        public DbSet<Cart> ShoppingCart { get; set; }

        public ThisContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Case>().HasKey(c => c.ID);
            modelBuilder.Entity<Cooler>().HasKey(c => c.ID);
            modelBuilder.Entity<Motherboard>().HasKey(c => c.ID);
            modelBuilder.Entity<CPU>().HasKey(c => c.ID);
            modelBuilder.Entity<Power>().HasKey(c => c.ID);
            modelBuilder.Entity<RAM>().HasKey(c => c.ID);
            modelBuilder.Entity<SSD>().HasKey(c => c.ID);
            modelBuilder.Entity<VideoCard>().HasKey(c => c.ID);
            modelBuilder.Entity<Cart>()
                .HasOne(c => c.ComputerCase)
                .WithMany()
                .HasForeignKey(c => c.CaseID);

            modelBuilder.Entity<Cart>()
                .HasOne(c => c.ComputerCooler)
                .WithMany()
                .HasForeignKey(c => c.CoolerID);

            modelBuilder.Entity<Cart>()
                .HasOne(c => c.Processor)
                .WithMany()
                .HasForeignKey(c => c.ProcessorID);

            modelBuilder.Entity<Cart>()
                .HasOne(c => c.PC_Motherboard)
                .WithMany()
                .HasForeignKey(c => c.MotherboardID);

            modelBuilder.Entity<Cart>()
                .HasOne(c => c.PowerSupply)
                .WithMany()
                .HasForeignKey(c => c.PowerSupplyID);

            modelBuilder.Entity<Cart>()
                .HasOne(c => c.Memory)
                .WithMany()
                .HasForeignKey(c => c.MemoryID);

            modelBuilder.Entity<Cart>()
                .HasOne(c => c.Storage)
                .WithMany()
                .HasForeignKey(c => c.StorageID);

            modelBuilder.Entity<Cart>()
                .HasOne(c => c.GraphicsCard)
                .WithMany()
                .HasForeignKey(c => c.GraphicsCardID);
        }
    }
}
