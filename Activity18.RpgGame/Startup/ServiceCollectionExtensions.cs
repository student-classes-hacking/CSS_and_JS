using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Activity18.RpgGame.Startup.ServiceCollectionExtensions;
using Activity18.RpgGame.Services.Implementations;
using Microsoft.Extensions.DependencyInjection;


namespace Activity18.RpgGame.Startup;


public static partial class ServiceCollectionExtensions
{
    public static IServiceCollection RegisterServices(this IServiceCollection services)
    {
        services.AddTransient<IGreetingService, GreetingService>();
        services.AddTransient<IMageService, MageService>();
        services.AddTransient<IWarriorService, WarriorService>();
        //services.AddTransient<IHeroGeneratorService, >();
        //services.AddTransient<IHeroService, >();
        //services.AddTransient<IRpgGameService, >();

        return services;
    }
    
    //TODO: Queda pendiente registrar el metodo start
}
