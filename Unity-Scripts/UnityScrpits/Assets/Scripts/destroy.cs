using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour {
    public GameObject go;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space))
        {
            Destroy(GetComponent<MeshRenderer>(), 1.0f);
        }
        else if (Input.GetKey(KeyCode.KeypadEnter))
        {
            Destroy(this, 1.0f);        // 销毁脚本自身，而不是其所挂载的组件
        }
        else if (Input.GetKey(KeyCode.Escape))
        {
            Destroy(gameObject, 1.0f);
        }
        else if (Input.GetKey(KeyCode.Backspace) && go != null)
        {
            Destroy(go, 1.0f);
        }
	}
}
