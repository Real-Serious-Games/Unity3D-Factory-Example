using RSG;
using RSG.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

interface IExampleFactoryCreatableByInterface
{
    void CheckSingletons();
}

[FactoryCreatable(typeof(IExampleFactoryCreatableByInterface))]
class ExampleFactoryCreatableByInterface : IExampleFactoryCreatableByInterface
{
    [Dependency]
    public IExampleUnitySingleton UnitySingleton { get; set; }

    [Dependency]
    public IExampleSingleton Singleton { get; set; }
        
    // The lazy singleton is not actually ever created unless it is requested (as it is here) for dependency injection.
    [Dependency]
    public IExampleLazySingleton LazySingleton { get; set; }

    [Dependency]
    public ILogger Logger { get; set; }

    public ExampleFactoryCreatableByInterface(ILogger logger)
    {
        logger.LogInfo("Created 'ExampleFactoryCreatableByInterface'");
    }

    public void CheckSingletons()
    {
        Logger.LogInfo("!! Singletons: ");
        Logger.LogInfo("    " + UnitySingleton.GetType().Name);
        Logger.LogInfo("    " + Singleton.GetType().Name);
        Logger.LogInfo("    " + LazySingleton.GetType().Name);
    }
}
