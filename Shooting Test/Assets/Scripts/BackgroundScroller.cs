/* 
Function used to scroll the background.
Creator: Iury Bizoni
Collaborators:

Date of last change: 10/15/2015
*/

using UnityEngine;
using System.Collections;

public class BackgroundScroller : MonoBehaviour
{
    public float scrollSpeed;

    void Start()
    {

    }

    void Update()
    {
        Vector2 offset = new Vector2(Time.time * scrollSpeed, 0);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}