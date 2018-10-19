using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public int health = 100;
    public int maxHealth = 100;
    public int minHealth = 0;

    //public GameObject PU_HealthSound;     //for sound

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        health = Mathf.Clamp(health, minHealth, maxHealth);
	}

    void IncreaseHealth()
    {
        health += 15;

        //PU_HealthSound.audio.play();       //error in syntax
    }

    void ApplyDamage()
    {
        health -= 10;
    }

}
