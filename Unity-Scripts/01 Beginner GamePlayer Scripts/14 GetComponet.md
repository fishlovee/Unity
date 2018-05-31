> 通过 getcomponet 可以获取其他组件，包括脚本  
> 要获取的组件必须是已经挂载在该脚本所挂载的游戏对象上的  

```C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push : MonoBehaviour {
    public GameObject go;
    public void OnMouseDown()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * 500f);
        GetComponent<Rigidbody>().useGravity = true;
    }
}
```

```c#
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

```