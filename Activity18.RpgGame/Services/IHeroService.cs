using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity18.RpgGame.Services;
public interface IHeroService
{
    int Hp { get; set; }
    string Name { get; set; }
    int Attack { get; set; }
    void ShowStats();
    void DecreaseHp(int attack);
    int GetAttackPower();
}
