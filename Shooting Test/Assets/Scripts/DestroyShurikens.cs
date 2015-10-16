/* 
Function used to destroy non-usable objects. Good to optimization.
Creator: Samuel Borges
Collaborators:

Date of last change: 10/15/2015
*/

using UnityEngine;
using System.Collections;

public class DestroyShurikens : MonoBehaviour
{

    //private ParticleSystem thisParticleSystem;

    // Use this for initialization
    void Start()
    {
        //thisParticleSystem = GetComponent<ParticleSystem>();
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

