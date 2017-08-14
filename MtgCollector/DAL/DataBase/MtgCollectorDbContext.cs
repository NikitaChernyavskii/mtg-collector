using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using DAL.Entities;

namespace DAL.DataBase
{
    public class MtgCollectorDbContext : DbContext
    {
        public MtgCollectorDbContext()
            : base("MtgCollector")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        #region DbSets

        public DbSet<CardSet> CardSets { get; set; }

        public DbSet<Card> Cards { get; set; }

        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
