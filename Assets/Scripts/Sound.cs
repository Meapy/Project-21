using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    private static Sound instance;

    private void Start()
    {
        Score.level = 0;
    }
    public static Sound Instance 
    

    {
        get { return instance; }
    }

    private void Update()
    {
        for(int i = 1; i <= 3; i++)
        {
            if (Score.level == i)
            {
                Destroy(gameObject);
            }
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

    
