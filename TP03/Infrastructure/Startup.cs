using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public static class Startup
    {
        public static void AddInfrastructure(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<BancoDeDados>(options => options.UseSqlServer(@"Server=tcp:portuga-azureserver.database.windows.net,1433;Initial Catalog=TP03Azure;Persist Security Info=False;User ID=paulo-portugal;Password=AaF27051992;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"));
            services.AddScoped<AmigosRepositorio>();
        }
    }
}
