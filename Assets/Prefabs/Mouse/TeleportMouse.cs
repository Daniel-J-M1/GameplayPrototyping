﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportMouse : MonoBehaviour {


    //public 
    private Vector2 George;

    // All tags that can teleport
    private string TagList = "|MouseHole|";

    // Use this for initialization
    void Start ()
    {


    }

	// Update is called once per frame
	void Update () {
        George = GameObject.FindWithTag("MouseHole").GetComponent<TeleMouseHole>().Location;
        //print(George);

        if (Input.GetButtonDown("Teleport"))
        {
            transform.position = George;

        }
        
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (TagList.Contains(string.Format("|{0}|", other.tag)))
        {
            print("George: " + George);
        }

    }
}