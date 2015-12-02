/* 
Script used to set player's config.
Creator: Samuel Borges
Collaborators: Carla Cremon, Iury Bizoni

Date of last change: 12/01/2015
*/

using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {


    //Rigidbody2D rb;
    //public bool grounded = true;
    public float jumpPower = 400;

    private bool isInvincible = false;
    private float timeSpentInvincible;

    // Use this for initialization
    void Start() {
        //rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate() {

        GetComponent<Animator>().SetBool("isHurt", false);
        //makes player jump when "space" is pressed"
        //	if(!grounded && GetComponent<Rigidbody2D>().velocity.y == 0) {
        //grounded = true;
        //}

        if (isInvincible)
        {
            timeSpentInvincible += Time.deltaTime;

            if (timeSpentInvincible < 1f)
            {
                float remainder = timeSpentInvincible % .3f;
                GetComponent<Renderer>().enabled = remainder > .15f;
            }
            else
            {
                GetComponent<Renderer>().enabled = true;
                isInvincible = false;
            }
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
		if (other.tag == "Ground")
        {
			if (Input.GetButtonDown("Jump") /*&& grounded == true*/) {
				Debug.Log("chao");
				GetComponent<Rigidbody2D>().AddForce(transform.up*jumpPower);
				//grounded = false;
			}	
		}
        if (!isInvincible && other.tag == "EnemyWeak")
        {
            HealthManager.HurtPlayer(1);
            //GetComponent<Animator>().SetBool("isHurt", true);
            isInvincible = true;
            timeSpentInvincible = 0;
        }
    }
}
