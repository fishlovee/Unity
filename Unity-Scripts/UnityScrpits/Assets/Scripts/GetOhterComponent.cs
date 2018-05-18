using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetOhterComponent : MonoBehaviour {
    private Push pushScript;
    private moveGo moveScript;

    private void Awake()
    {
        pushScript = GetComponent<Push>();
        moveScript = GetComponent<moveGo>();
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

    private void OnMouseDown()
    {
        pushScript.OnMouseDown();
    }
}
