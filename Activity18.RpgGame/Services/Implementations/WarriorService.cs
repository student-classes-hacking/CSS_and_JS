using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Activity18.RpgGame.Services.Implementations;

public class WarriorService : HeroService, IWarriorService
{
	// DE LA INTERFAZ "IHEROSERVICE"
	public int Hp { get; set; }
	public string Name { get ; set ; }
	public int Attack { get ; set ; }
	//__________________________________________
	// DE LA INTERFAZ "IWARRIORSERVICE"
	public int Defence { get; set; }

	public override void DecreaseHp(int attack)
	{
		Hp -= (attack - (Defence / 3));
	}

	public int GetAttackPower()
	{
		return Attack;
	}

	public void ShowStats()
	{
		Console.WriteLine($"Su Nombre es {Name}");
		Console.WriteLine($"Su vida es de {Hp}");
		Console.WriteLine($"Su ataque es de {Attack}");
		Console.WriteLine($"Su defensa es {Defence}");
	}
}
