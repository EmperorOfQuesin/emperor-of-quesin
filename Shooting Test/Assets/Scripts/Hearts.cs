using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Hearts : MonoBehaviour {

    //public Sprite[] HeartSprites;
    public Image HeartUI;
    public HealthManager healthManager;
    
    // Use this for initialization
	void Start () {

      //  healthManager = GameObject.FindObjectOfType<HealthManager>();

	}
	
	// Update is called once per frame
	void Update () {

        //HeartUI.sprite = HeartSprites[healthManager.playerHealth];

    }

    public void FullLife()
    {

    }
}
