using Core.Entity.Concrete;
using Entities;
using Entities.Mapping;
using Entities.SqlViews;
using Entities.SqlViewsMapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Galeri> Galeriler { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Araba> Arabalar { get; set; }
        public DbSet<Siparis> Siparisler { get; set; }
        public DbSet<SiparisDetay> SiparisDetaylar { get; set; }
        public DbSet<V_ArabaVeGaleriTablosu> ArabaVeGaleriTablosu { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArabaMap());
            modelBuilder.ApplyConfiguration(new GaleriMap());
            modelBuilder.ApplyConfiguration(new MusteriMap());
            modelBuilder.ApplyConfiguration(new SiparisMap());
            modelBuilder.ApplyConfiguration(new SiparisDetayMap());
            modelBuilder.ApplyConfiguration(new V_ArabaVeGaleriTablosuMap());
            modelBuilder.Entity<V_ArabaVeGaleriTablosu>().ToView("V_ArabaVeGaleriTablosu");
            base.OnModelCreating(modelBuilder);
        }
        public override int SaveChanges()
        {
            List<EntityEntry> modifiedEntries = ChangeTracker.Entries().Where(x => x.State == EntityState.Added || x.State == EntityState.Modified).ToList();

            string identity = WindowsIdentity.GetCurrent().Name;
            string computerName = Environment.MachineName;
            DateTime dateTime = DateTime.Now;
            int user = 1;
            string ip = "1";

            foreach (var item in modifiedEntries)
            {
                CoreEntity entity = item.Entity as CoreEntity;
                if (item != null)
                {
                    if (item.State == EntityState.Added)
                    {
                        entity.CreatedADUserName = identity;
                        entity.CreatedComputerName = computerName;
                        entity.CreatedDate = dateTime;
                        entity.CreatedIP = ip;
                        entity.CreatedBy = user;
                    }
                    else if (item.State == EntityState.Modified)
                    {
                        entity.ModifiedADUserName = identity;
                        entity.ModifiedComputerName = computerName;
                        entity.ModifiedDate = dateTime;
                        entity.ModifiedIP = ip;
                        entity.ModifiedBy = user;

                    }

                }

            }
            return base.SaveChanges();
        }
    }
}
