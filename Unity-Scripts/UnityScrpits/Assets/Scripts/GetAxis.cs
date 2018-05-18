using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetAxis : MonoBehaviour {

    public float range;
    public string textOutput;

    private void Start()
    {
        //textOutput = new Text();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float xPos = h * range;

        transform.position = new Vector3(xPos, 2f, 0);
        textOutput = "Value Returned: " + h.ToString("F2");
    }
}
