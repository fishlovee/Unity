using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoker : MonoBehaviour {
    public GameObject rg;
	// Use this for initialization
	void Start () {
        InvokeRepeating("InstantiateSphere", 2,1);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Q))
        {
            CancelInvoke("InstantiateSphere");
        }
	}

    private void InstantiateSphere()
    {
        Instantiate(rg, transform.position, transform.rotation);
    }
}
