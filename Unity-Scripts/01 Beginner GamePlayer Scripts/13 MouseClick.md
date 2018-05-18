

1. 创建一个plane，transform 置0
2. 创建一个球体，并添加刚体，取消重力，高度设置为2
3. 添加以下脚本到球体

```C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push : MonoBehaviour {
    private void OnMouseDown()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * 500f);
        GetComponent<Rigidbody>().useGravity = true;
    }
}

```