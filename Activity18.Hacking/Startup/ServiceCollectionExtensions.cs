using Activity18.Hacking.Services.Implementations;

namespace Activity18.Hacking.Startup;

public static partial class ServiceCollectionExtensions
{
    public static IServiceCollection RegisterServices(this IServiceCollection services) => services.AddSingleton<JSService>();
}