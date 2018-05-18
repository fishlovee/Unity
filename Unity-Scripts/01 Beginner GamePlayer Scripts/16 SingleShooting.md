## 最简单的射击

**知识点**
1. 实例化预制体
2. 销毁对象
3. 移动对象


**步骤**
1. 创建 plane 
2. 创建 cube ，添加 脚本 
3. 创建 sphere ，添加 纹理、脚本、刚体，将 sphere 制作为预制体 
4. 将 sphere 预制体 拖拽到 cube 的 bullet 上

**代码如下：**
```C#
// SingleCharacterScript.cs
using UnityEngine;
using System.Collections;

public class SingleCharacterScript : MonoBehaviour
{
    public class Stuff
    {
        public int bullets;
        public int grenades;
        public int rockets;

        public Stuff(int bul, int gre, int roc)
        {
            bullets = bul;
            grenades = gre;
            rockets = roc;
        }
    }


    public Stuff myStuff = new Stuff(10, 7, 25);
    public float speed;
    public float turnSpeed;
    public Rigidbody bulletPrefab;
    public Transform firePosition;
    public float bulletSpeed;


    void Update()
    {
        Movement();
        Shoot();
    }


    void Movement()
    {
        float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

        transform.Translate(Vector3.forward * forwardMovement);
        transform.Rotate(Vector3.up * turnMovement);
    }


    void Shoot()
    {
        if (Input.GetButtonDown("Fire1") && myStuff.bullets > 0)
        {
            Rigidbody bulletInstance = Instantiate(bulletPrefab, transform.position, transform.rotation) as Rigidbody;
            bulletInstance.AddForce(transform.forward * bulletSpeed);
            myStuff.bullets--;
        }
    }
}
```


```c#
//DestroyBullet.cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Destroy(gameObject, 1.5f);
	}

}

```