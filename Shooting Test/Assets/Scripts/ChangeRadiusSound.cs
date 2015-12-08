using UnityEngine;
using System.Collections;

public class ChangeRadiusSound : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeRadiusSong()
    {
        gameObject.GetComponent<AudioSource>().enabled = true;
    }

}
