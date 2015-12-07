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
       // for (index = 0; index < 5; index++)
            //ammunition[index] = (GameObject)Instantiate(bullet, new Vector3(Camera.main.aspect * Camera.main.orthographicSize + 1, Camera.main.orthographicSize + index), firePosition.rotation);
            //ammunition[index] = (GameObject)Instantiate(bullet, new Vector3(-6, index), firePosition.rotation);
    }
    /*
        IEnumerator Reload(float reloadbullet)
        {
            yield return new WaitForSeconds(reloadbullet);
            bullets++;
            if (bullets >= 5)
                bullets = 5;
        }*/

    void Update()
    {
        Debug.Log(bullets);
        Vector3 currentPosition = transform.position;
        //  StartCoroutine(Reload(1f));
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