using Entities;
using System;
using System.Data.Entity;

namespace SQLRepository
{
    public class MyDbContext : DbContext
    {
        public DbSet<Memories> Memories { set; get; }

        public MyDbContext()
        : base("ConnectionString")
        {
            base.Configuration.ProxyCreationEnabled = false;

            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
            #if DEBUG
                        Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
            #endif

            Database.SetInitializer<MyDbContext>(new CreateDatabaseIfNotExists<MyDbContext>());
            Database.SetInitializer<MyDbContext>(null);
        }
    }
}
