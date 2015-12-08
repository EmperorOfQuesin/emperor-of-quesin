﻿/*
Script used to manage the start button interaction
Creator: Iury Bizoni
Colaborator: Samuel Borges

Date of last change: 12/08/2015
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
    //void OnMouseDown()
    //{
    //    Invoke("LoadLevel", 0);
    //}

    

    public void InstructionLevel()
    {
        Application.LoadLevel("InstructionScene");
    }

    public void LoadLevel()
    {
        Application.LoadLevel("1");
    }

    public void Credits()
    {
        //Application.LoadLevel("Credits");
    }
}
