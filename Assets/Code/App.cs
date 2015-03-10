using RSG;
using RSG.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class App
{
    public static App Instance
    {
        get;
        private set;
    }

    public IFactory Factory
    {
        get;
        private set;
    }

    private ISingletonManager singletonManager;

    public static void Startup()
    {
        if (Instance == null)
        {
            Instance = new App();
        }        
    }

    private App()
    {
        var logger = new UnityLogger();
        var factory = new Factory("App", logger);
        factory.Dep<ILogger>(logger);

        factory.AutoRegisterTypes();
        this.singletonManager = factory.AutoInstantiateSingletons();
        this.Factory = factory;
        this.singletonManager.Startup();
    }

    public void Shutdown()
    {
        singletonManager.Shutdown();
    }
}

