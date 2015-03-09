using RSG;
using RSG.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

interface IExampleLazySingleton
{

}

[LazySingleton(typeof(IExampleLazySingleton))]
class ExampleLazySingleton : IExampleLazySingleton
{
    public ExampleLazySingleton(ILogger logger)
    {
        logger.LogInfo("'ExampleLazySingleton' lazily created");
    }

}
