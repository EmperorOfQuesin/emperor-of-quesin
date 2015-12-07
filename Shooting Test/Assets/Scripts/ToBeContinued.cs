/* 
Function used to popup TO BE CONTINUED.
Creator: Samuel Borges
Collaborators:

Date of last change: 12/05/2015
*/
using UnityEngine;
using System.Collections;

public class ToBeContinued : MonoBehaviour {

    public Renderer rend;

	// Use this for initialization
	void Start () {

        rend = GetComponent<Renderer>();
        rend.enabled = false;

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ToBeContinuedRenderer()
    {
        rend.enabled = true;
        gameObject.GetComponent<AudioSource>().enabled = true;
    }
}
