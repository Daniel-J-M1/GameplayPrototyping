using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    //Create a Speed property that can be changed in the editor
    public float Speed = 1f;
    public float JumpHight = 5f;
    //public bool IsGrounded;
    public Rigidbody2D Rigid;
    // Use this for initialization
    void Start () {
        Rigid = GetComponent<Rigidbody2D>();
	}

    //private void OnCollisionEnter2D(Collision2D collision)
    ///{
        
    //}

    //void oncoll

    // Update is called once per frame
    void Update () {

        //Creates a float value for the Direction of the object on the X axis when either the left and right movement keys are pressed.
        float DirX = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
        float DirY = Input.GetAxis("Jump") * JumpHight * Time.deltaTime;

        if (true) //IsGrounded check goes here
        {
            if (Input.GetButtonDown("Jump"))
            {
                Rigid.AddForce(Vector2.up * 5f, ForceMode2D.Impulse);
            }
        }

        Rigid.AddForce(Input.GetAxis("Horizontal") * Vector2.right * Speed, ForceMode2D.Impulse);
        // Continuously updates the position of the character - Allows for movement when the "DirX" variable changes
       // transform.position = new Vector2(transform.position.x + DirX, transform.position.y + DirY);

        //if (Rigid.detectCollision == true)
        //{

       // }
    }
}
