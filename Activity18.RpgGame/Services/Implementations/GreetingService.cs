using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity18.RpgGame.Services.Implementations;

public class GreetingService : IGreetingService
{
    public void Run()
    {
        Console.WriteLine("Hola, ¡bienvenido al servicio de saludos!");
    }
}