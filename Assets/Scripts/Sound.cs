using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sound : MonoBehaviour
{
    private static Sound instance;

  public static Sound Instance 
    

    {
        get { return instance; }
    }

    private void Update()
    {
        for(int i = 0; i < 3; i++)
        {
            if (Score.level == i)
            {
                Destroy(gameObject);
            }
        }
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
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

    
