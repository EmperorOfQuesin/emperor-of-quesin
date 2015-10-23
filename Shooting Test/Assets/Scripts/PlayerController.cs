/* 
Function used to set player's config.
Creator: Samuel Borges
Collaborators: Carla Cremon

Date of last change: 10/21/2015
*/

using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	
	Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}

    // Update is called once per frame
    void Update() {
		//makes player jump when "space" is pressed"
		if (Input.GetButtonDown("Jump")) {
			rb.AddForce(new Vector2(0,8), ForceMode2D.Impulse);
		}
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "EnemyWeak")
        {
            HealthManager.HurtPlayer(1);
        }
                
    }
}
