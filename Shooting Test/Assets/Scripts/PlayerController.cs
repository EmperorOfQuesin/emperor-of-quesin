/* 
Function used to set player's config.
Creator: Samuel Borges
Collaborators:

Date of last change: 10/20/2015
*/

using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {


	// Use this for initialization
	void Start () {

	}

    // Update is called once per frame
    void Update() {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "EnemyWeak")
        {
            HealthManager.HurtPlayer(1);
        }
                
    }
}
