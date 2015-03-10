using RSG;
using RSG.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

class ExampleDependencyInjectedMonoBehavior : MonoBehaviour
{
    [Dependency]
    public ILogger Logger { get; set; }

    void Start()
    {
        // Assume the App singleton has already been booted!
        App.Instance.Factory.ResolveDependencies(this);

        Logger.LogInfo("I'm a dependency injected MonoBehaviour!");
    }
}
