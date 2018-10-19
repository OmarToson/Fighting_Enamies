using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour {

    public int ammoCount = 60;

    public int backUpAmmo = 240;

    // public GameObject AmmoSound;     //for sound

    //public GameObject PU_AmmoSound;     //for sound

    void Start () {
		
	}
	
	
	void Update ()
    {
        /*
        if (AmmoSound.active == false)
        {
           AmmoSound.active = true;
        }

        AmmoSound.audio.play();       //error in syntax
        */
        if (ammoCount == 0 || Input.GetKeyDown("r") && ammoCount < 60 && backUpAmmo > 0)
        {
            int neededAmmo = 60 - ammoCount;
            if (backUpAmmo > neededAmmo)
            {
                backUpAmmo -= neededAmmo;
                ammoCount += neededAmmo;
            }
            else
            {
                ammoCount += backUpAmmo;
                backUpAmmo = 0;
            }
        }
/*
        if (Input.GetMouseButton(0) && ammoCount > 0)
        {
            ammoCount -= 1;
        }
*/


        /*
        else if (backUpAmmo == 0 ) {
            if (AmmoSound.active == true)
            {
                AmmoSound.active = false;
            }
        }
        */

    }

    void IncreaseAmmo()
    {
        backUpAmmo += 200;

        //PU_AmmoSound.audio.play();       //error in syntax
    }

}
