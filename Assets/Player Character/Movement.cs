using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    //Create a Speed property that can be changed in the editor
    public float Speed = 10f;
    //Create a Jump Hight Variable
    public float JumpHight = 100f;
    //Create a reference for the rigid body in the script
    public Rigidbody2D Rigid;

    // Use this for initialization
    void Start () {
        //Gives Rigid Context
        Rigid = GetComponent<Rigidbody2D>();
	}

    // Update is called once per frame
    void Update () {

        //Creates a float value for the Direction of the object on the X axis when either the left and right movement keys are pressed.
        float DirX = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
        float DirY = Input.GetAxis("Jump") * JumpHight * Time.deltaTime;


        int layer_mask = 1 << LayerMask.NameToLayer("Ground");

        float ray_length = GetComponent<Collider2D>().bounds.extents.y+0.05f;
        bool grounded = Physics2D.Raycast(transform.position, Vector2.down, ray_length, layer_mask);
        if (grounded == true) //IsGrounded check goes here
        {
            if (Input.GetButtonDown("Jump"))
            {
                //Rigid.AddForce(Vector2.up * JumpHight, ForceMode2D.Impulse);

                Vector2 velocity = Rigid.velocity;

                velocity.y += 30.0f;

                Rigid.velocity = velocity;
            }
        }

        Rigid.AddForce(Input.GetAxis("Horizontal") * Vector2.right * Speed, ForceMode2D.Impulse);

    }
}
