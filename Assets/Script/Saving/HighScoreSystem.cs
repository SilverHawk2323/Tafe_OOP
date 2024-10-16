using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScoreSystem : MonoBehaviour
{
    private List<string> names = new List<string>();
    private List<float> scores = new List<float>();

    public int maxScores = 10;

    public Transform panel;
    public TMP_Text textPrefab;

    private void Start()
    {
        /*NewScore("sadsa", 3);
        NewScore("Sara", 1);
        NewScore("RRR", 6);
        NewScore("Dom", 9);
        NewScore("Anthony", 2);
        NewScore("Batman", 5);*/



        RefreshScoreDisplay();
    }

    private void RefreshScoreDisplay()
    {
        //Destroy all children
        //panel

        for(int i = panel.childCount - 1; i  >= 0; i--)
        {
            Destroy(panel.GetChild(i).gameObject);
        }

        

        for(int i = 0; i < scores.Count; i++)
        {
            Debug.Log(names[i] + " scored: " + scores[i]);

            TMP_Text text = Instantiate(textPrefab, panel);
            text.text = names[i];

            text = Instantiate(textPrefab, panel);
            text.text = scores[i].ToString();
        }
    }

    string[] possibleNames = { "Anthony", "Dom", "Sara", "Batman", "Alex", "Andrew" };

    public void NewScore(float score)
    {
        NewScore(possibleNames[Random.Range(0, possibleNames.Length)], score);
    }

    public void NewScore(string name, float score)
    {
        for (int i = 0; i < scores.Count ; i++)
        {
            if(score < scores[i])
            {
                scores.Insert(i, score);
                names.Insert(i, name);
                RefreshScoreDisplay();
                if(scores.Count > maxScores)
                {
                    scores.RemoveAt(scores.Count - 1);
                    names.RemoveAt(names.Count - 1);
                }
                return;
            }
        }

        if (scores.Count > maxScores)
        {
            return;
        }

        scores.Add(score);
        names.Add(name);
        RefreshScoreDisplay();
    }
}
