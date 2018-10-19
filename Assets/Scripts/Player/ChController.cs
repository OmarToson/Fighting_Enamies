using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChController : MonoBehaviour {

    private CharacterController chrController;

    private Vector3 movedirection;

    public float speed = 10;
	
	void Awake () {
        chrController = GetComponent("CharacterController") as CharacterController;

    }
	
	
	void Update () {

        GetInput();

        chrController.Move(movedirection * Time.deltaTime);

    }

    void GetInput() {
        float dead = 0.01f;

        movedirection = Vector3.zero;

        if (Input.GetAxis("Horizontal") > dead || Input.GetAxis("Horizontal") < -dead)
        {
            movedirection += new Vector3(Input.GetAxis("Horizontal")*speed, 0, 0);
        }

        if (Input.GetAxis("Vertical") > dead || Input.GetAxis("Vertical") < -dead)
        {
            movedirection += new Vector3(0, 0, Input.GetAxis("Vertical") * speed);
        }

    }
}
