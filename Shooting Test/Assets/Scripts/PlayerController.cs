/* 
Script used to set player's config.
Creator: Samuel Borges
Collaborators: Carla Cremon, Iury Bizoni

Date of last change: 12/08/2015
*/

using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public AudioSource hurtEffectSound;

    public float jumpPower = 400;

    private bool isInvincible = false;
    private float timeSpentInvincible;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void FixedUpdate() {

        GetComponent<Animator>().SetBool("isHurt", false);

        if (transform.position.y >= -2 && transform.position.y <= 1.9 && Input.GetButtonDown("Jump"))
            GetComponent<Animator>().SetBool("isGrounded", true);
        else
            GetComponent<Animator>().SetBool("isGrounded", false);

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
        if (!isInvincible && other.tag == "EnemyWeak")
        {
            HealthManager.HurtPlayer(1);
            isInvincible = true;
            timeSpentInvincible = 0;
            hurtEffectSound.Play();
        }

    }
}
