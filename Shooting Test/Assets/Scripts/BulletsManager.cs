/* 
Function used to display the remaining bullets.
Creator: Iury Bizoni
Collaborators:

Date of last change: 12/06/2015
*/
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BulletsManager : MonoBehaviour {

    public Sprite[] BulletSprite;
    public Image BulletUI;
    public static int bulletsLeft;

    // Use this for initialization
    void Start () {
        bulletsLeft = 5;
	
	}
	
	// Update is called once per frame
	void Update () {
        BulletUI.sprite = BulletSprite[bulletsLeft];
	}
    public static void PlayerShot(int bulletShot)
    {
        bulletsLeft -= bulletShot;
    }
    public static void Reload(int bulletReloaded)
    {
        bulletsLeft += bulletReloaded;
    }
}
