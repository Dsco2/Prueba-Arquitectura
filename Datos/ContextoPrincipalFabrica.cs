using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class ContextoPrincipalFabrica : IDesignTimeDbContextFactory<ContextoPrincipal>
    {
        public ContextoPrincipal CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ContextoPrincipal>();
            builder.UseNpgsql(
            @"Host=localhost;Database=LEC-Core-LocalDb;Username=postgres;Password=admin",
            optionsBuilder => optionsBuilder
            .MigrationsAssembly(typeof(ContextoPrincipal)
            .GetTypeInfo()
            .Assembly
            .GetName().Name)             
                );
            return new ContextoPrincipal(builder.Options);
        }
    }
}
