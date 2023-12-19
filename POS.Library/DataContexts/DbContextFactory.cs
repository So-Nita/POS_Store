using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using POSLibrary.DataContexts;
using POSLibrary.Models;

namespace POSLibrary.DataContexts
{
    internal class DbContextFactory : IDesignTimeDbContextFactory<PosContext>
    {
        public PosContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<PosContext> dbContextOptionsBuilder = new();
            var connectionStrings = "Server=172.26.16.90;Database=pos;port=3306;user=POS01;password=ttDev@2023;Persist Security Info=False;Connect Timeout=120;";
            
            dbContextOptionsBuilder.UseMySql(connectionStrings,ServerVersion.AutoDetect(connectionStrings));

            return new PosContext(dbContextOptionsBuilder.Options);
        }
    }
}
