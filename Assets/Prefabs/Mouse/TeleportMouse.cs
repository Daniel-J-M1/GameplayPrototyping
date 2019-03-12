using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportMouse : MonoBehaviour {

    public Vector2 Pos = GameObject.Find("MouseHoles").GetComponent<TeleMouseHole>().Pos;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider Hole)
    {
        if (Hole.gameObject.CompareTag("MouseHole"))
        {
            print("colided");
        }
    }
}
