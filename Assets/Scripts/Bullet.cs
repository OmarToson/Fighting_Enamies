using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public int speed = 200;

    public GameObject Expl;

	void Start () {
		
	}
	
	
	void Update () {
        transform.position += transform.TransformDirection(new Vector3(0, speed * Time.deltaTime, 0));
        Destroy(gameObject, 1.5f);
    }

    void OnCollisionEnter(Collision collision)
    {
        Instantiate(Expl, transform.position, Quaternion.identity);
        collision.gameObject.SendMessage("ApplyDamage" , SendMessageOptions.DontRequireReceiver);
        Destroy(gameObject);
    }
}
