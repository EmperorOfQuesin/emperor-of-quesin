/*
Script used to manage the instruction button interaction
Creator: Samuel Borges
Colaborator:

Date of last change: 12/05/2015
*/

using UnityEngine;
using System.Collections;

public class InstructionScene : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //When clicked the startbutton will load the next scene, starting the game
    void OnMouseDown()
    {
        Invoke("LoadLevel", 0);
    }

    public void LoadLevel()
    {
        Application.LoadLevel("InstructionScene");
    }
}
