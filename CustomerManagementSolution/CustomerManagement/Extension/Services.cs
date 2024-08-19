using CustomerManagement.Models;
using CustomerManagement.Repo;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.Extension
{
    public static class Services
    {
        public static IServiceCollection AddCustomerLibrary(this IServiceCollection services, string connectionString) 
        {
            services.AddDbContext<CustomermngContext>(options =>options.UseSqlServer(connectionString));
            services.AddScoped<ICustomerLogin, CustomerLogin>();
            return services;
        }
    }
    
}
