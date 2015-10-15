using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    public GameObject bullet;
    public float speed;
    public Transform firePosition;
    GameObject prefab;

    PlayerController player;

    private Vector3 moveDirection;


    // Use this for initialization
    void Start()
    {
        moveDirection = Vector3.right;
        Vector3 currentPosition = new Vector3(-5, -1, 0);
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

            //Vector3 target = moveDirection * speed + currentPosition;
            //transform.position = Vector3.Lerp(currentPosition, target, Time.deltaTime);


            GameObject projectile = (GameObject)Instantiate(bullet, firePosition.position, firePosition.rotation);
            projectile.GetComponent<Rigidbody2D>().velocity = moveDirection * speed;

        }
    }

    private void EnforceBounds()
    {
        Vector3 newPosition = transform.position;
        Camera mainCamera = Camera.main;
        Vector3 cameraPosition = mainCamera.transform.position;

        float xDist = mainCamera.aspect * mainCamera.orthographicSize;
        float xMax = cameraPosition.x + xDist;
        float xMin = cameraPosition.x - xDist;

        if (newPosition.x < xMin || newPosition.x > xMax)
        {
            newPosition.x = Mathf.Clamp(newPosition.x, xMin, xMax);
            moveDirection.x = -moveDirection.x;
        }
        float yMax = mainCamera.orthographicSize;

        if (newPosition.y < -yMax || newPosition.y > yMax)
        {
            newPosition.y = Mathf.Clamp(newPosition.y, -yMax, yMax);
            moveDirection.y = -moveDirection.y;
        }

        transform.position = newPosition;
     
    }
}