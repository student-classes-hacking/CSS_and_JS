using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity18.RpgGame.Services;
public interface IHeroGeneratorService
{
    IMageService GenerateMage();
    IWarriorService GenerateWarrior();
    IHeroService GenerateHero();


}
