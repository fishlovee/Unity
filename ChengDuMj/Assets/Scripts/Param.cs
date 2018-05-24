using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Param : MonoBehaviour {
    static public bool zpCheck = true;
    static public bool hpCheck = true;

	// Use this for initialization
	void Start () {
        GameObject.DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
