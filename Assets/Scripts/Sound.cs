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
    private void Update()
    {
        if (Score.level == 2)
        {
            Destroy(gameObject);
        }
    }
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }

        
    }
}

    
