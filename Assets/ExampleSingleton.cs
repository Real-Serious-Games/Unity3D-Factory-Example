using RSG;
using RSG.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

interface IExampleSingleton
{

}

[Singleton(typeof(IExampleSingleton))]
class ExampleSingleton : IExampleSingleton, IStartable
{
    [Dependency]
    public ILogger Logger { get; set; }

    [Dependency]
    public IFactory Factory { get; set; }

    public void Startup()
    {
        Logger.LogInfo("Started 'ExampleSingleton'");

        // Create some objects by name via the factory:
        var someObjectCreatedByName1 = Factory.Create<IExampleFactoryCreatableByName>("Some-Factory-Creatable-Object-1");
        Logger.LogInfo("Created by name: " + someObjectCreatedByName1.Msg);

        var someObjectCreatedByName2 = Factory.Create<IExampleFactoryCreatableByName>("Some-Factory-Creatable-Object-2");
        Logger.LogInfo("Created by name: " + someObjectCreatedByName2.Msg);

        // Create an object by interface via the factory.
        var someObjectCreatedByInterface = Factory.CreateInterface<IExampleFactoryCreatableByInterface>();
        someObjectCreatedByInterface.CheckSingletons();
    }

    public void Shutdown()    
    {
        Logger.LogInfo("Shutdown 'ExampleSingleton'");
    }
}
