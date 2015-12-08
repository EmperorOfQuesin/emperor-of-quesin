/* 
Script used to spawn monsters randomly (can be as much monster as you want).
Creator: Samuel Borges
Collaborators: Iury Bizoni

Date of last change: 12/08/2015
*/

using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{

    bool isSpawning = false;
    public float minTime = 5.0f;
    public float maxTime = 15.0f;
    public GameObject[] enemies;  // Array of enemy prefabs.
    float yMax;
    public bool spawn = true;
    public int teste = 0;
    public int teste1 = 0;

    void Start()
    {
        yMax = Camera.main.orthographicSize - 0.5f;
    }

    IEnumerator SpawnObject(int index, float seconds)
    {
        if (spawn)
        {
            yield return new WaitForSeconds(seconds);
            //check whether this script is attached to saquirrelspawn or not and based on that, spawn the respective enemy
            if (gameObject.name == "squirrelspawn")
            {
                Instantiate(enemies[index], new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
            }
            else if(gameObject.name == "SpawnPoint")
            {
                Instantiate(enemies[index], new Vector3(transform.position.x, Random.Range(0, yMax), transform.position.z), transform.rotation);
            }
            //We've spawned, so now we could start another spawn     
            isSpawning = false;
        }
    }

    void Update()
    {
        //We only want to spawn one at a time, so make sure we're not already making that call
        if (!isSpawning && spawn)
        {
            isSpawning = true; //Yep, we're going to spawn
            int enemyIndex = Random.Range(0, enemies.Length);
            StartCoroutine(SpawnObject(enemyIndex, Random.Range(minTime, maxTime)));
        }
    }

    public void ResetTime()
    {
        spawn = false;
    }

    public void ChangeRadius()
    {
        minTime = 1;
        maxTime = 3;
    }
}