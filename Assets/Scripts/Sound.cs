using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    private static Sound instance;

    /*
    public static Sound Instance 
    

    {
        get { return instance; }
    }
    */

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }

        if (Application.loadedLevel == 2)
        {
            Destroy(gameObject);
        }
    }
}

    
