
using Microsoft.EntityFrameworkCore;
using ETicaretAPI.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services) //IoC konteynerimin arayuzune bir extension fonksiyon sagliyor.Bu fonk uzerinden ben direkt Ioc konteynerime datalarimi gonderebiliyorum.
        {
            services.AddDbContext<ETicaretAPIDbContext>(options => options.UseNpgsql(Configuration.ConnectionString)); //connection string kod icine manuel verilmemeli
        }


    }
}
