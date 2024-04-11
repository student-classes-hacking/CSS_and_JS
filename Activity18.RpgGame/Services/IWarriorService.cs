using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity18.RpgGame.Services;
public interface IWarriorService : IHeroService
{
    int Defence { get; set; }
}
