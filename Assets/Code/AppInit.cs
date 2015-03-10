using RSG;
using RSG.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

/// <summary>
/// This MonoBehavior must be manually added to a GameObject to bootstrap the application/Factory.
/// </summary>
public class AppInit : MonoBehaviour
{
    void Awake()
    {
        App.Startup();
    }

    void Start()
    {        
    }

    void OnApplicationQuit()
    {
        App.Instance.Shutdown();
    }
}
