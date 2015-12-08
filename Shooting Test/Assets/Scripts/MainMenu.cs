/*
Script used to manage the title screen
Creator: Samuel Borges
Colaborator: Iury Bizoni

Date of last change: 12/08/2015
*/
using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour
{

    //public string levelSelect;

    public GameObject mainMenuCanvas;

    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StoryMode()
    {
        Application.LoadLevel("1");
    }

    public void Instructions()
    {
        Application.LoadLevel("InstructionScene");
    }

    public void Credits()
    {
        Application.LoadLevel("CreditsScene");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
