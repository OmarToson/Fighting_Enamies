using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public GameObject Bullet;

    public Transform ShootPoint;

    public float restTime;

    public float rTime;

	void Start () {
		
	}
	
	void Update () {

        if (Input.GetMouseButton(0))
        {
            if (rTime >=0)
            {
                rTime -= Time.deltaTime;
            }

            if (rTime <= 0)
            {
                var ammoScript = GetComponent("Ammo") as Ammo;
                if (ammoScript.ammoCount > 0)
                {
                    ammoScript.ammoCount -= 1;

                    Instantiate(Bullet, ShootPoint.position, ShootPoint.rotation);
                }
                rTime = restTime;
            }
           
        }
        else
        {
            rTime = 0;
        }
	}
}
