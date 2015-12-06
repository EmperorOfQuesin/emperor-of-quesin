/* 
Function used to controll when the boss spawns.
Creator: Iury Bizoni
Collaborators: Samuel Borges

Date of last change: 12/05/2015
*/
using UnityEngine;
using System.Collections;

public class BossController : MonoBehaviour {

    ToBeContinued toBeContinued;

    // Use this for initialization
    void Start() {
        toBeContinued = FindObjectOfType<ToBeContinued>();
    }

    // Update is called once per frame
    void Update() {

    }

    //This method is called when the requirements for spawning the boss are completed.
    public void BossIsHere()
    {
        GetComponent<Animator>().SetBool("bossFlag", true);
        ToBeContinuedAppears();
    }

    public void ToBeContinuedAppears()
    {
        Invoke("ToBeContinuedAppears2", 10);
    }

    public void ToBeContinuedAppears2()
    {
        toBeContinued.ToBeContinuedRenderer();
    }
}
