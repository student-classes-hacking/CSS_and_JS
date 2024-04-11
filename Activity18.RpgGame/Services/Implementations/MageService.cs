using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity18.RpgGame.Services.Implementations;

public class MageService : IMageService
{
    public int Power { get; set; }
    public int Hp { get; set; }
    public string Name { get; set; }
    public int Attack { get; set; }

    public void DecreaseHp(int attack)
    {
        Hp = Hp - attack;
    }

    public int GetAttackPower()
    {
        return (Power/5) + Attack;
    }

    public void ShowStats()
    {
        Console.WriteLine($"El mago {Name} tiene {Hp} de salud y {Attack} de poder de ataque.$");
    }

}
