using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Services
{
    public static class ServiceRegistiration
    {
        //Bu metod ile webApi projesindeki program.cs dosyasında tüm handlerları tanımlamama gerek kalmıyor.Tek bir kodla oluyor.Mediator design kullanımı için.
        public static void AddApplicationService(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(ServiceRegistiration).Assembly));
        }
    }
}
