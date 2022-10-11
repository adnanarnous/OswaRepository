using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace OswaTech.EntityFrameworkCore
{
    public static class OswaTechDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<OswaTechDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<OswaTechDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
