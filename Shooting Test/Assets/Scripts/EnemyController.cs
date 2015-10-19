/* 
Function used to controll the enemy.
Creator: Samuel Borges
Collaborators: Iury Bizoni

Date of last change: 10/15/2015
*/

using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

    public float enemySpeed;

    public Transform spawnPoint;

    public GameObject enemy;

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(enemySpeed, 0);
        spawnPoint = GameObject.Find("SpawnPoint").transform;
	
	}

    // Update is called once per frame
    void Update() {

        //The following Variables store the position from the player and from the enemies
        float playerPos = GameObject.Find("Player").transform.position.y;
        float enemyPos = GetComponent<Rigidbody2D>().position.y;

        //checks if the enemy has reached the middle of the screen
        if (GetComponent<Rigidbody2D>().position.x <= 0)
        {
            //if the enemy is above the player it will go down, the further it's from the player, the higher its speed will be
            if(playerPos < enemyPos)
                GetComponent<Rigidbody2D>().velocity = new Vector2(enemySpeed, 1.5f*(playerPos - enemyPos));
            //the same as the previous if, but this time it will go up if the enemy is below the player
            else if(playerPos > enemyPos)
                GetComponent<Rigidbody2D>().velocity = new Vector2(enemySpeed, 1.5f*(playerPos - enemyPos));
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {

    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
