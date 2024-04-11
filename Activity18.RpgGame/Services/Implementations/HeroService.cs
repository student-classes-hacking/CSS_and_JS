using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity18.RpgGame.Services.Implementations
{
    public abstract class HeroService : IHeroService
    {
        public int Hp {get;set;}
        public string Name {get; set;}
        public int Attack {get;set;}

        public abstract void DecreaseHp(int attack);

        public int GetAttackPower()
        {
            return Attack;
        }

        public void ShowStats()
        {
            Console.WriteLine($"Su Nombre es {Name}");
            Console.WriteLine($"Su vida es de {Hp}");
            Console.WriteLine($"Su ataque es de {Attack}");
        }
    }
}
