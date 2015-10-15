using UnityEngine;
using System.Collections;

public class TestBackground : MonoBehaviour
{
    //The speed at which texture scrolls
    public float scrollSpeed;

    void Start()
    {

    }

    void Update()
    {

        //Update the offset value based on time
        float offset = Time.time * scrollSpeed;

        //Apply the offset value back to the material(This will offset in X axis

        GetComponent<Renderer>().material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }
}