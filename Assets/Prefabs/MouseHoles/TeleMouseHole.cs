using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleMouseHole : MonoBehaviour {

    public Vector2 Pos;

    public GameObject Hole1;
    public GameObject Hole2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider Hole)
    {
        if (Hole.gameObject.CompareTag("Player"))
        {
            Pos = transform.position;

        }
    }
}
