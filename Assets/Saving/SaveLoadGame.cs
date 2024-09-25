using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoadGame : MonoBehaviour
{
    public void SaveGame()
    {
        GameData data = new GameData();
        JsonSaveLoad.Save(data);
    }

    public void LoadGame()
    {
        GameData data = JsonSaveLoad.Load();
        Debug.Log(data.data);
    }
}
