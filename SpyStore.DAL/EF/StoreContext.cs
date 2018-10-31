using Microsoft.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore.Infrastructure;

using SpyStore.Models.Entities;

namespace SpyStore.DAL.EF
{
    public class StoreContext: DbContext
    {
        public StoreContext() { }

        public StoreContext(DbContextOptions options) : base(options){ }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=PC-ERIC211\SQLEXPRESS2014;Database=SpyStore;persist security info=True;user id=sa;password=P@ssw0rd99;;MultipleActiveResultSets=true;");
                //,options => options.ExecutionStrategy(c => new MyExecutionStrategy(c))
            }
        }

        public virtual DbSet<Category> Categories { get; set; }

    }
}
