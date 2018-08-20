using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneControl : MonoBehaviour {
    public float speed = 3;
    public float rotateRate = 0;
    private long lDirection = 1;
    private float rotateSpeed = 30;
    // Use this for initialization
    void Start () {
        rotateSpeed = Random.Range(20, 60);
        lDirection = Random.Range(0, 2) > 1? -1 : 1;
    }
	
	// Update is called once per frame
	void Update ()
    {
		Vector3 v = new Vector3(0,0,lDirection) * rotateRate * rotateSpeed;
        transform.Translate(Vector3.back * speed * Time.deltaTime);
        transform.Rotate(v);
	}
}
