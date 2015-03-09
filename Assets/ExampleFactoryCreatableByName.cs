using RSG;
using RSG.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

interface IExampleFactoryCreatableByName
{
    string Msg { get; }
}

[FactoryCreatable("Some-Factory-Creatable-Object-1")]
class ExampleFactoryCreatableByName1 : IExampleFactoryCreatableByName
{
    public ExampleFactoryCreatableByName1(ILogger logger)
    {
        logger.LogInfo("Created 'ExampleFactoryCreatableByName'");
    }

    public string Msg 
    { 
        get
        {
            return "ExampleFactoryCreatableByName1";
        }
    }
}

[FactoryCreatable("Some-Factory-Creatable-Object-2")]
class ExampleFactoryCreatableByName2 : IExampleFactoryCreatableByName
{
    public ExampleFactoryCreatableByName2(ILogger logger)
    {
        logger.LogInfo("Created 'ExampleFactoryCreatableByName'");
    }

    public string Msg 
    { 
        get
        {
            return "ExampleFactoryCreatableByName2";
        }
    }
}
