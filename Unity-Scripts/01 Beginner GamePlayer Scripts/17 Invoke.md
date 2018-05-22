> Invoke 可以用来延时回调指定函数，配套的还有 InvokeRepeating , CancelInvoke


1. 创建一个plane
2. 创建一个空的游戏对象，并添加以下脚本
3. 创建一个带有刚体的预制体，并拖拽到脚本的rg上
4. 运行，每2s产生1个rg，按Q键退出
```C#
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

```

https://unity3d.com/cn/learn/tutorials/topics/scripting/enumerations?playlist=17117