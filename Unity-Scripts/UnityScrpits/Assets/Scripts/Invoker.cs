using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoker : MonoBehaviour {
    public GameObject rg;
    private int nCount;
	// Use this for initialization
	void Start () {
        nCount = 1;
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
        GameObject go = Instantiate(rg, transform.position, transform.rotation);
        go.transform.Translate(new Vector3(1,1,1)* 100*nCount*Time.deltaTime);
        nCount++;
    }
}
