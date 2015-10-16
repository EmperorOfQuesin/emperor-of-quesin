/* 
Function used to controll the enemy.
Creator: Samuel Borges
Collaborators:

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
	void Update () {

	}

    void OnTriggerEnter2D(Collider2D other)
    {

    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
