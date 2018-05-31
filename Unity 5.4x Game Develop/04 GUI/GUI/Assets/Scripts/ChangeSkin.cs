using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSkin : MonoBehaviour {
    public GUISkin[] skins;
    private int index = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space))
        {
            index++;
            if (index >= skins.Length)
            {
                index = 0;
            }
        }
	}

    private void OnGUI()
    {
        GUI.skin = skins[index];
        if (GUI.Button(new Rect(Screen.width/3,Screen.height/3,Screen.width/3,Screen.height/3),"我是button"))
        {
            Debug.Log("Button");
        }
    }
}
