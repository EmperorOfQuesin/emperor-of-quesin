/* 
Function used to manipulate player's health.
Creator: Samuel Borges
Collaborators:

Date of last change: 12/05/2015
*/

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{

    public Sprite[] HeartSprites;
    public Image HeartUI;

    public int maxPlayerHealth;
    public static int playerHealth;

    Text text;

    public bool isDead;

    // Use this for initialization
    void Start()
    {

        text = GetComponent<Text>();

        playerHealth = maxPlayerHealth;

        isDead = false;
    }

    // Update is called once per frame
    void Update()
    {

        HeartUI.sprite = HeartSprites[playerHealth];

        if (playerHealth == 6)
        {

        }

        if (playerHealth <= 0 && isDead == false)
        {
            playerHealth = 0;
            RespawnPlayer();
            FullHealth();   
            isDead = true;
        }

        if (isDead == true)
            isDead = false;


        text.text = "" + playerHealth;
    }

    public static void HurtPlayer(int damageToGive)
    {
        playerHealth -= damageToGive;
    }

    public void FullHealth()
    {
        playerHealth = maxPlayerHealth;
    }

    public void RespawnPlayer()
    {
        Application.LoadLevel("LoseScene");

    }
}
