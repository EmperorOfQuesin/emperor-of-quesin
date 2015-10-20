/*
Script used to manage the start button interaction
Creator: Iury Bizoni
Colaborator:

Date of last change: 10/19/2015
*/
using UnityEngine;
using System.Collections;

public class StartScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update () {
       
	}

    //When clicked the startbutton will load the next scene, starting the game
    void OnMouseDown()
    {
        Invoke("LoadLevel", 0);
    }

    void LoadLevel()
    {
        Application.LoadLevel("1");
    }
}
