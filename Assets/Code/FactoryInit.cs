using RSG;
using RSG.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

/// <summary>
/// This MonoBehavior must be manually added to a GameObject to bootstrap the Factory.
/// </summary>
public class FactoryInit : MonoBehaviour
{
    private ISingletonManager singletonManager;

    void Awake()
    {
        var logger = new UnityLogger();
        var factory = new Factory("App", logger);
        factory.Dep<ILogger>(logger);

        factory.AutoRegisterTypes();
        this.singletonManager = factory.AutoInstantiateSingletons();

        // ... can now create objects via the factory ...
    }

    void Start()
    {
        singletonManager.Startup();
    }

    void OnDestroy()
    {
        singletonManager.Shutdown();
    }
}
