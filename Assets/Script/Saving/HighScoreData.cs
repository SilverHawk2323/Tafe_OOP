using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//JUST HERE TO BE ABLE TO BE TURNED INTO A JSON
//MONOBEHAVIOURS CANT BE SERIALIZED WHICH MEANS IT CANT BE JSON
[System.Serializable]
public class HighScoreData
{
    public float[] scores;
    public string[] names;

    //Constructor
    public HighScoreData()
    {
        scores = new[] { 99f, 10f, 1f };
        names = new[] { "Andrew", "Adam", "Eve" };
    }

    public HighScoreData(float[] scores, string[] names)
    {
        this.scores = scores;
        this.names = names;
    }
}
