> lookat 函数可以用来将相机跟随指定的物体

有2种方法
1. 直接将 camera 子类化为目标物体
2. 为 camera 添加以下脚本，并将目标物体拖拽到 target 
```C#
using UnityEngine;
using System.Collections;

public class CameraLookAt : MonoBehaviour
{
    public Transform target;
    
    void Update ()
    {
        transform.LookAt(target);
    }
}
```