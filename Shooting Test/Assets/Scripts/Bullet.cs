/* 
Function used to instantiate and change bullet's position.
Creator: Samuel Borges
Collaborators:

Date of last change: 10/15/2015
*/

using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    public GameObject bullet;
    public float speed;
    public Transform firePosition;
    GameObject prefab;

    private Vector3 moveDirection;

    // Use this for initialization
    void Start()
    {
        moveDirection = Vector3.right; //Vector
    }

    void Update()
    {
        Vector3 currentPosition = transform.position;

        if (Input.GetButtonDown("Fire1"))
        {

            Vector3 moveToward = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            moveDirection = moveToward - currentPosition;
            moveDirection.z = 0;
            moveDirection.Normalize();

            GameObject projectile = (GameObject)Instantiate(bullet, firePosition.position, firePosition.rotation);
            projectile.GetComponent<Rigidbody2D>().velocity = moveDirection * speed;

        }
    }

}