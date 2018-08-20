using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotate : MonoBehaviour {
    public float tumple = 5;
	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().angularVelocity = tumple * Random.insideUnitSphere;
	}
}
