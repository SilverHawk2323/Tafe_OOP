using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public static class JsonSaveLoad 
{
#if UNITY_EDITOR
    public static string fileHS = Application.dataPath + "/saveHS.json";
    public static string filePosition = Application.dataPath + "/savePos.json";
#else
    public static string file = Application.persistentDataPath + "/save.json";
    public static string filePosition = Application.persistentDataPath + "/savePos.json";
#endif

    public static void Save(HighScoreData data)
    {
        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(fileHS, json);
    }

    public static HighScoreData Load()
    {
        if (File.Exists(fileHS))
        {
            string json = File.ReadAllText(fileHS);
            return JsonUtility.FromJson<HighScoreData>(json);
        }
        return null;
    }
}
