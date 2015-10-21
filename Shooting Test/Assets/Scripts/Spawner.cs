/* 
Function used to spawn randomly monsters (can be as much monster as you want).
Creator: Samuel Borges
Collaborators:

Date of last change: 10/20/2015
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


    void Start()
    {
        yMax = Camera.main.orthographicSize - 0.5f;
    }

    IEnumerator SpawnObject(int index, float seconds)
    {
        yield return new WaitForSeconds(seconds);
        Instantiate(enemies[index], new Vector3(transform.position.x, Random.Range(-yMax, yMax), transform.position.z), transform.rotation);

        //We've spawned, so now we could start another spawn     
        isSpawning = false;
    }

    void Update()
    {
        //We only want to spawn one at a time, so make sure we're not already making that call
        if (!isSpawning)
        {
            isSpawning = true; //Yep, we're going to spawn
            int enemyIndex = Random.Range(0, enemies.Length);
            StartCoroutine(SpawnObject(enemyIndex, Random.Range(minTime, maxTime)));
        }
    }
}