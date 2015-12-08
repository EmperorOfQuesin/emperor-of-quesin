/* 
Function used to change scores at the screen.
Creator: Samuel Borges
Collaborators: Iury Bizoni

Date of last change: 12/08/2015
*/

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public static int score;

    Text text;

    public Spawner scoreToEndsquirrel;
    public Spawner scoreToEndbat;

    public Spawner scoreMiddleSquirrel;
    public Spawner scoreMiddleBat;

    public BossController bossTrigger;

    public BackgroundScroller backgroundScroller;

    public FasterSound fasterSound;
    public ChangeRadiusSound changeRadiusSound;

    void Start()
    {
        scoreMiddleBat = GameObject.Find("SpawnPoint").GetComponent<Spawner>();
        scoreMiddleSquirrel = GameObject.Find("squirrelspawn").GetComponent<Spawner>();

        scoreToEndbat = GameObject.Find("SpawnPoint").GetComponent<Spawner>();
        scoreToEndsquirrel = GameObject.Find("squirrelspawn").GetComponent<Spawner>();

        bossTrigger = GameObject.FindObjectOfType<BossController>();

        backgroundScroller = GameObject.FindObjectOfType<BackgroundScroller>();

        fasterSound = GameObject.FindObjectOfType<FasterSound>();
        changeRadiusSound = GameObject.FindObjectOfType<ChangeRadiusSound>();

        text = GetComponent<Text>();

        score = 0;

    }

    void Update()
    {

        if (score < 0)
            score = 0;

        text.text = "" + score;

        if (score == 15)
        {
            backgroundScroller.StopSound();
            scoreMiddleBat.ChangeRadius();
            scoreMiddleSquirrel.ChangeRadius();
            fasterSound.StartFasterSound();
            changeRadiusSound.ChangeRadiusSong();
            //backgroundScroller.ChangeVelocityBackground();
        }

        if (score >= 30)
        {
            scoreToEndbat.ResetTime();
            scoreToEndsquirrel.ResetTime();
            bossTrigger.BossIsHere();
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
