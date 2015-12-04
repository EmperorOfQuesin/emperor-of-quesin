/* 
Function used to controll when the boss spawns.
Creator: 
Collaborators: Iury Bizoni

Date of last change: 12/03/2015
*/
using UnityEngine;
using System.Collections;

public class BossController : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    //This method is called when the requirements for spawning the boss are completed.
    public void BossIsHere()
    {
        GetComponent<Animator>().SetBool("bossFlag", true);
    }
}
