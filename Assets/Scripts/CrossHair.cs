using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossHair : MonoBehaviour {

    public Texture2D Crosshair; 

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnGUI()
    {
        Cursor.visible = false;

        Rect crossRect = new Rect(Input.mousePosition.x - Crosshair.width/4, (Screen.height - Input.mousePosition.y) - Crosshair.height / 4, Crosshair.width/2, Crosshair.height/2);

        GUI.DrawTexture(crossRect, Crosshair);
    }
}
