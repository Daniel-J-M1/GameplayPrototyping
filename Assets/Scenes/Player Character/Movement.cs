using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    //Create a Speed property that can be changed in the editor
    public float Speed = 10;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //Creates a float value for the Direction of the object on the X axis when either the left and right movement keys are pressed.
        float DirX = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
        float DirY = Input.GetAxis("Jump") * Speed * Time.deltaTime;

        // Continuously updates the position of the character - Allows for movement when the "DirX" variable changes
        transform.position = new Vector2(transform.position.x + DirX, transform.position.y + DirY);

	}
}
