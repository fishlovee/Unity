> The time in seconds it took to complete the last frame (Read Only).  
> deltaTime 是每帧动画完成所用的时间，如果将一个值乘以 deltaTime ，这个乘积将在固定的时间内改变固定的值  
**例子**
````C#
using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour {
    void Update() {
        float translation = Time.deltaTime * 10;
        transform.Translate(0, 0, translation);
    }
}
```

> 以上代码将每秒移动物体10个单位，而不受设备、动画帧数的影响。  
> 例如，有设备A、B分别以10帧/秒和20帧/秒运行该代码，则：
```#
transformA = deltaTimeA * 10 * timeA = 1/10*10*10 = 10
transformB = deltaTimeB * 10 * timeB = 1/20*10*20 = 10
```

```C#
using UnityEngine;
using System.Collections;

public class UsingDeltaTime : MonoBehaviour
{
    public float speed = 8f; 
    public float countdown = 3.0f;

    
    void Update ()
    {
        countdown -= Time.deltaTime;
        if(countdown &lt;= 0.0f)
            light.enabled = true;
        
         if(Input.GetKey(KeyCode.RightArrow))
            transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
    }   
}
```