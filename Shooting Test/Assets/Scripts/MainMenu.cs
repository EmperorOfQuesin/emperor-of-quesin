using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour
{

    //public string levelSelect;

    public GameObject mainMenuCanvas;

    void Start()
    {

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
