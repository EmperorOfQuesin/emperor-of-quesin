/*
Script used to manage the back button interaction
Creator: Samuel Borges
Colaborator:

Date of last change: 12/08/2015
*/

using UnityEngine;
using System.Collections;

public class MainScene : MonoBehaviour
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
        Application.LoadLevel("LaunchScene");
    }
}
