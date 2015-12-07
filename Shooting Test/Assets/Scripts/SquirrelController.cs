/* 
Script used to control the squirrel.
Creator: Iury Bizoni
Collaborators:

Date of last change: 12/06/2015
*/

using UnityEngine;
using System.Collections;

public class SquirrelController : MonoBehaviour
{

    public GameObject deathParticle;

    public float enemySpeed;

    public Transform spawnPoint;

    public GameObject enemy;

    public bool resistance = true;


    public int pointsOnDeath; //How many points a monster will give (Setup in Unity)

    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(enemySpeed, 0);
        spawnPoint = GameObject.Find("squirrelspawn").transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        GetComponent<Animator>().SetBool("squirrelHurt", false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // check if the squirrel is colliding with a bullet, otherwise it shouldn't be destroyed
        if (other.tag == "Shuriken")
        {
            if (resistance == false) //Destroy the enemy and the bullet if the enemy is not invincible
            {
                Destroy(gameObject);
                Instantiate(deathParticle, other.transform.position, other.transform.rotation); 
                Destroy(other.gameObject);
                ScoreManager.AddPoints(pointsOnDeath);
                resistance = true;
            }
            Destroy(other.gameObject);
            GetComponent<Animator>().SetBool("squirrelHurt", true);
            resistance = false;
        }
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
