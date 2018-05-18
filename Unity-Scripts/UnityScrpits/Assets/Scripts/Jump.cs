using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Jump"))
        {
            Debug.Log("GetButton");
        }

        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("GetButtonDown");
        }

        if (Input.GetButtonUp("Jump"))
        {
            Debug.Log("GetButtonUp");
        }
    }
}
