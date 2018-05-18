> 以 GetButton GetButtonDown GetButtonUp 为例说明，同 GetKey 系列


**按键顺序**
1. 按下按键时， GetButton 第一个被激活，直到放开按键才变为false
2. GetButton 被激活后， GetButtonDown 跟着被激活，但立马变为 false ，不是持续的
3. 放开按键时， GetButton 先变为 false ，然后是 GetButtonUp 变为 true 

```C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Jump"))
        {
            Debug.Log("GetButton");
        }

        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("GetButtonDown");
        }

        if (Input.GetButtonUp("Jump"))
        {
            Debug.Log("GetButtonUp");
        }
    }
}
```

**输出**
> GetButton  
GetButtonDown  
GetButton  
GetButton  
GetButton  
GetButton  
GetButton  
GetButton  
GetButtonUp  


