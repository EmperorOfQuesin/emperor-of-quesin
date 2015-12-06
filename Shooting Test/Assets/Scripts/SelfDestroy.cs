/* 
Script used to destroy particle effects.
Creator: Samuel Borges
Collaborators: 

Date of last change: 12/01/2015
*/

using UnityEngine;
using System.Collections;

public class SelfDestroy : MonoBehaviour {

    public void Destroy()
    {
        Destroy(gameObject);
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
