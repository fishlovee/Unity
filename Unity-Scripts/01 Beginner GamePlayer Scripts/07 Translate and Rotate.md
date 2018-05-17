> 通过 Rotate 对 物体进行旋转，  Translate 对物体进行移动

```C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveGo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.transform.Rotate(Vector3.up * rotated * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.Rotate(Vector3.down * rotated * Time.deltaTime);
        }
    }

    public float speed = 100f;
    public float rotated = 50f;
}
```