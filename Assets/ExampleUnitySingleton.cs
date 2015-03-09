using RSG;
using RSG.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

interface IExampleUnitySingleton
{
}

[UnitySingleton(typeof(IExampleUnitySingleton))]
class ExampleUnitySingleton : MonoBehaviour, IExampleUnitySingleton
{
    [Dependency]
    public ILogger Logger { get; set; }

    void Start()
    {
        Logger.LogInfo("Started 'ExampleUnitySingleton'");
    }

    void OnDestroy()
    {
        Logger.LogInfo("Started 'ExampleUnitySingleton'");
    }
}

