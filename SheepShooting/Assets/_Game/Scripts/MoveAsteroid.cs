using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAsteroid : MonoBehaviour {
    public float speed = -2;
	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().velocity = transform.forward* speed;// 沿着自身的Y轴前进
    }
}
