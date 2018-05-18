### Destroy
> Destroy 可以销毁指定的游戏对象（组件）


**步骤**
1. 创建一个plane
2. 在plane 上创建一个 sphere ，并添加脚本 Destroy.cs 以及如下代码
3. 将 plane 拖拽到 destroy 脚本 的 go 变量上

```C#
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
            Destroy(GetComponent<MeshRenderer>(), 1.0f);  // 销毁游戏对象的 MeshRenderer 
        }  
        else if (Input.GetKey(KeyCode.KeypadEnter))
        {
            Destroy(this, 1.0f);        // 销毁脚本自身，而不是其所挂载的组件
        }
        else if (Input.GetKey(KeyCode.Escape))
        {
            Destroy(gameObject, 1.0f);  // 销毁 脚本及其所挂载的游戏对象
        }
        else if (Input.GetKey(KeyCode.Backspace) && go != null)
        {
            Destroy(go, 1.0f);  // 销毁 plane
        }
	}
}
```



