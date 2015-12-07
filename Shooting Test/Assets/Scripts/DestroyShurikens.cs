/* 
Function used to destroy non-usable objects. Good to optimization.
Creator: Samuel Borges
Collaborators:

Date of last change: 12/07/2015
*/

using UnityEngine;
using System.Collections;

public class DestroyShurikens : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}

