using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public struct LevelSaveData
{
    public LevelScoresData[] Data;

    public LevelSaveData(LevelScoresData[] data)
    {
        Data = data;
    }

}
