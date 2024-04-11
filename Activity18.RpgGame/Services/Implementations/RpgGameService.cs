//using System;
//using System.Collections.Generic;
//using System.Diagnostics.CodeAnalysis;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Activity18.RpgGame.Services.Implementations;

//public class RpgGameService : IRpgGameService
//{
//    protected readonly IHeroGeneratorService _generatorService;
//    public RpgGameService(IHeroGeneratorService generatorService)
//    {
//        _generatorService = generatorService;
//    }

//	public void Start()
//	{
//        IMageService mago = _generatorService.GenerateMage();
//        IWarriorService guerrero = _generatorService.GenerateWarrior();
//        //TODO
//	}
//}