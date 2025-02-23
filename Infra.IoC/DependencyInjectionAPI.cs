using Application.Interfaces;
using Application.Service;
using Domain.Interfaces;
using Infra.Data.Context;
using Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.IoC;

public static class DependencyInjectionAPI {
    public static IServiceCollection AddInfrastructureAPI(this IServiceCollection services, IConfiguration configuration) {

        services.AddDbContext<ApplicationDbContext>(options =>
         options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"
        ), b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

        services.AddScoped<ICalendarRepository, CalendarRepository>();
        services.AddScoped<ICalendarService, CalendarService>();

        return services;
    }
}