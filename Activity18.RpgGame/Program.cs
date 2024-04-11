using Activity18.RpgGame.Services.Implementations;
using Activity18.RpgGame.Startup;

// TODO: Una vez hayas hecho la implementación de la inyección de dependencias, deberás de obtener una instancia de la
// IRpgGame y llamar al método Start() para que la aplicación funcione correctamente. .



using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;

using IHost host = Host.CreateDefaultBuilder(args)
            .ConfigureServices((_, services) =>
            {
                services.RegisterServices();    
            })
            .Build();

var service = host.Services.GetRequiredService<IGreetingService>();
service.Run();
//perfecto
await host.RunAsync();

