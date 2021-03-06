﻿/*
Script used to manage Pause Menu interaction.
Creator: Samuel Borges
Colaborator:

Date of last change: 12/08/2015
*/

using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

    public string mainMenu;

    public bool isPaused;

    public GameObject pauseMenuCanvas;

    public Bullet bullet;
	
    void Start()
    {
        bullet = FindObjectOfType<Bullet>();
    }

	// Update is called once per frame
	void Update () {

        if (isPaused)
        {
            pauseMenuCanvas.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            pauseMenuCanvas.SetActive(false);
            Time.timeScale = 1f;
            bullet.ResumeShoot();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            bullet.PauseShoot();
            isPaused = !isPaused;
        }
	}

    public void Resume()
    {
        isPaused = false;
        bullet.ResumeShoot();
    }

    public void Quit()
    {
        Application.LoadLevel("LaunchScene");
    }
}
