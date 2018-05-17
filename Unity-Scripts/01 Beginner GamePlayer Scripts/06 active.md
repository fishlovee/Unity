### activeSelf 、 activeInHierarchy 和 SetActive

**activeSelf**
1. The local active state of this GameObject. (Read Only)  
2. 表示物体本身的active状态，对应于其在inspector中的checkbox是否被勾选。
3. 如果具有父类继承关系，则如果父对象的 activeSelf 为 false ，则子对象即使是 true 也不会显示。一个物体只有自己和其父对象都为true时，才会显示，否则隐藏。


**activeInHierarchy** 
1. Is the GameObject active in the scene?  (ReadOnly)
2. 表示物体在层次中是否是active的。也就是说要使这个值为true，这个物体及其所有父物体(及祖先物体)的activeself状态都为true。


**SetActive**
1. SetActive 对应于 activeSelf ， SetActive 操作相当于在 inspection 对 CheckBox 进行操作
2. 参数：false  true


```C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkstate : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
        gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        //Debug.Log("activeSelf:" + gameObject.activeSelf);
        //Debug.Log("Active in Hierarchy" + gameObject.activeInHierarchy);
	}
}
```