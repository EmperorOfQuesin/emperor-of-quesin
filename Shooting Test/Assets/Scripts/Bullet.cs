/* 
Function used to instantiate and change bullet's position.
Creator: Samuel Borges
Collaborators: Iury Bizoni

Date of last change: 12/06/2015
*/

using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    public GameObject bullet;
    public float speed;
    public Transform firePosition;
    GameObject prefab;
    private int bullets = 5;
    private int time = 0;
    GameObject[] ammunition;
    private int index;


    private Vector3 moveDirection;

    // Use this for initialization
    void Start()
    {
        moveDirection = Vector3.right;
    }

    void Update()
    {
        //Debug.Log(bullets);
        Vector3 currentPosition = transform.position;
        time++;

        if (time % 50 == 0 && bullets < 5)
        {
            bullets++;
            BulletsManager.Reload(1);
        }

        if (bullets > 0)
        {
            if (Input.GetButtonDown("Fire1"))
            {

                Vector3 moveToward = Camera.main.ScreenToWorldPoint(Input.mousePosition);

                moveDirection = moveToward - currentPosition;
                moveDirection.z = 0;
                moveDirection.Normalize();

                GameObject projectile = (GameObject)Instantiate(bullet, firePosition.position, firePosition.rotation);
                projectile.GetComponent<Rigidbody2D>().velocity = moveDirection * speed;
                bullets--;
                BulletsManager.PlayerShot(1);
            }
        }
    }
}