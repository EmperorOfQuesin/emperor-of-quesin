using UnityEngine;
using System.Collections;

public class FasterSound : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void StartFasterSound()
    {
        gameObject.GetComponent<AudioSource>().enabled = true;
    }

}
