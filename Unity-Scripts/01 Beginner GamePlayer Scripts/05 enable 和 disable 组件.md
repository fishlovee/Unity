
1. 在场景的 Directional Light 添加脚本
2. 在脚本中添加以下代码：


```C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disablelight : MonoBehaviour {

	// Use this for initialization
	void Start () {
        myLight = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            myLight.enabled = myLight.enabled = !myLight.enabled;
        }
	}

    private Light myLight;
}

```