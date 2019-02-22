using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour {
    public GameObject Camera1;
    public GameObject Camera2;
    public Texture texture;

    void Start()
    {
        Camera1.SetActive(true);
        Camera2.SetActive(false);
    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(0, 0, 100, 100), texture))
        {
            Camera1.SetActive(true);
            Camera2.SetActive(false);
        }
        if (GUI.Button(new Rect(100, 0, 100, 100), texture))
        {
            Camera1.SetActive(false);
            Camera2.SetActive(true);
        }
    }
    // Found at https://answers.unity.com/questions/911949/ui-buttons-switch-cameras.html
}
