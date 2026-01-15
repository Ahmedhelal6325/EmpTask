using EmpTask.Data;
using Microsoft.EntityFrameworkCore;

namespace EmpTask.Extentions
{
    public static class ServiceExtensions
    {
        public static void ConfigureProviders(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
