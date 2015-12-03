/* 
Function used to change scores at the screen.
Creator: Samuel Borges
Collaborators:

Date of last change: 12/03/2015
*/

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public static int score;

    Text text;

    public Spawner scoreToEnd;

    void Start()
    {
        scoreToEnd = FindObjectOfType<Spawner>();
        text = GetComponent<Text>();

        score = 0;

    }

    void Update()
    {
        if (score < 0)
            score = 0;

        text.text = "" + score;

        if (score == 2)
        {
            scoreToEnd.ResetTime();
        }
    }

    public static void AddPoints(int pointsToAdd)
    {
        score += pointsToAdd;
    }

    public static void Reset()
    {
        score = 0;
    }
}
