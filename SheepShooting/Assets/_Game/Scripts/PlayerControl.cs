using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {
    public float speed;
    public GameObject shot;
    public GameObject shotSpawn;
    public float fireRate = 0.1f;

    private float nextUpdate = 0;
    //private Rigidbody rg;
	// Use this for initialization
	void Start () {
        //rg = GetComponent<Rigidbody>();
        nextUpdate = Time.time;
    }
	
	// Update is called once per frame
	void Update () {
        MoveSheep();
        Shot();
    }

    private void MoveSheep()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(h, 0, v) * speed * Time.deltaTime;
        //rg.AddForce(move);
        transform.Translate(move);
    }

    private void Shot()
    {
        if (Input.GetButton("Fire1") && Time.time > nextUpdate)
        {
            nextUpdate = Time.time + fireRate;
            Instantiate(shot, shotSpawn.transform);
        }
    }
}
