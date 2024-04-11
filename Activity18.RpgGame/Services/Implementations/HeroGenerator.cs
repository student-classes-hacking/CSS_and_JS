using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity18.RpgGame.Services.Implementations
{
    public class HeroGenerator : IHeroGeneratorService
    {
        protected readonly IServiceProvider _serviceProvider;
        public HeroGenerator(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public IMageService GenerateMage() => _serviceProvider.GetService(typeof(IMageService)) as IMageService ?? throw new Exception("No hay un IMageService");


        public IWarriorService GenerateWarrior()
        {
            return _serviceProvider.GetService(typeof(IWarriorService)) as IWarriorService ?? throw new Exception("No hay un IMageService");
        }

        public IHeroService GenerateHero() 
        { 
            IHeroService? result = null;
            var rnd = new Random();
            var serviceType = rnd.Next(2); // Genera 0 o 1 aleatoriamente

            if (serviceType == 0)
            {
                result = _serviceProvider.GetService(typeof(IMageService)) as IMageService ?? throw new Exception("No hay un IMageService");
            }
            else
            {
                result = _serviceProvider.GetService(typeof(IWarriorService)) as IWarriorService ?? throw new Exception("No hay un IMageService");
            }

            return result;

        }
    }
}
