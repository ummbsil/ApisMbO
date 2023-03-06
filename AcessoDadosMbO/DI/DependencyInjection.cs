using AcessoDadosMbO.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDadosMbO.DI
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfraStructureDb(
           this IServiceCollection services,
           IConfiguration configuration)
        {
            var provider = services.AddDbContext<ObjetivoContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("ObjetivoConnection"))) //ForumConnection será referenciado no projeto que utilizar essa biblioteca
                .BuildServiceProvider();

            var context = provider.GetRequiredService<ObjetivoContext>();
            DbInitializer.Initialize(context);

            return services;
        }
    }
}
