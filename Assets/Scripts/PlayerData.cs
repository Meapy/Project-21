using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{

    public int Level1Highscore;
    public int Level2Highscore;
    public int Level3Highscore;

    public PlayerData(LoadGame player)
    {
        Level1Highscore = LoadGame.Level1Highscore;
        Level2Highscore = LoadGame.Level2Highscore;
        Level3Highscore = LoadGame.Level3Highscore;
    }

}