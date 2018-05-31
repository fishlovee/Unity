> update 是每一帧都会调用，而 fixedupdate 则是固定时间调用  

**使用区别**
1. update 由于和帧数有关，因此如果是高帧数则相同单位时间执行的次数多，否则执行次数少。同时，该函数的执行频率还和设备的性能以及渲染物体的复杂度有关。  
2. fixedupdate 是固定间隔时间执行，不受游戏帧率的影响。Tick：在处理Rigidbody的时候最好用FixedUpdate。  


```C#
using UnityEngine;
using System.Collections;

public class UpdateAndFixedUpdateTest : MonoBehaviour
{
    void FixedUpdate ()
    {
        Debug.Log("FixedUpdate time :" + Time.fixedDeltaTime);
    }


    void Update ()
    {
        Debug.Log("Update time :" + Time.deltaTime);
    }
}
```

> 可以看到输出间隔，fixedupdate 是固定的，而 update 则不固定