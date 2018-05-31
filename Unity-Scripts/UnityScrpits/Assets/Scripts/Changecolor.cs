using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changecolor : MonoBehaviour {

	// Use this for initialization
	void Start () {
        defaultColor = GetComponent<Renderer>().material.color;
        //defaultColor = GetComponent<Material>().color; // 没有挂载到
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.R))
        {
            //gameObject.renderer.material.color = Color.red; 已经过时，使用 GetComponent<Renderer>() 替代
            GetComponent<Renderer>().material.color = Color.red;
        }
        else if (Input.GetKey(KeyCode.G))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
        else if (Input.GetKey(KeyCode.B))
        {
            GetComponent<Renderer>().material.color = Color.black;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Renderer>().material.color = defaultColor;
        }
	}

    private Color defaultColor;
}


public class UpdateAndFixedUpdate : MonoBehaviour
{
    void FixedUpdate()
    {
        Debug.Log("FixedUpdate time :" + Time.fixedDeltaTime);
    }


    void Update()
    {
        Debug.Log("Update time :" + Time.deltaTime);
    }
}