/* 
Script used to controll the squirrel.
Creator: Iury Bizoni
Collaborators:

Date of last change: 11/30/2015
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

    //private Color invincibleColor = new Color(0.8f, 0.3f, 0.3f); (APAGAR)

    public int pointsOnDeath; //How many points a monster will give (Setup in Unity)

    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(enemySpeed, 0);
        spawnPoint = GameObject.Find("squirrelspawn").transform;
    }

    // Update is called once per frame
    void Update()
    {
       //////////////////////// LEMBRAR DE APAGAR ISSO SE NÃO FOR USAR!!!! ///////////////////////


        //The following Variables store the position from the player and from the enemies
        //float playerPos = GameObject.Find("Player").transform.position.y;
        //float enemyPos = GetComponent<Rigidbody2D>().position.y;

        //checks if the enemy has reached the middle of the screen
        /*
        if (GetComponent<Rigidbody2D>().position.x <= 0)
        {

            //at this point the enemy becomes invincible and its color is changed
            isInvincible = true;
            GetComponent<SpriteRenderer>().color = invincibleColor;

            /*
            //if the enemy is above the player it will go down, the further it's from the player, the higher its speed will be
            if (playerPos < enemyPos)
                GetComponent<Rigidbody2D>().velocity = new Vector2(enemySpeed, 2.0f * (playerPos - enemyPos));
            //the same as the previous if, but this time it will go up if the enemy is below the player
            else if (playerPos > enemyPos)
                GetComponent<Rigidbody2D>().velocity = new Vector2(enemySpeed, 2.0f * (playerPos - enemyPos));
    
        }
    */
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
            resistance = false;
        }
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
