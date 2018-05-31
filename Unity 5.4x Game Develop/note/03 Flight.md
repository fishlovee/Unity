### 飞行控制
> 主要逻辑
1. 螺旋桨旋转
```c#
transform.Rotate(0,1,0);    // 沿着主轴旋转，Y轴。
```

2. 根据tag获取游戏对象
```c#
Gameobject.FindWithTag("airplane");
```

3. 获取鼠标屏幕位置、宽度信息及点击事件
```c#
float width = Screen.width;                         // 获取屏幕宽度

// 鼠标
Vector3 pos = Input.mousePosition;                  // 获取鼠标当前位置
Input.GetMouseButton(n);                            // 获取鼠标点击，0,1,2分别表示鼠标左键、右键、中键

// 触摸屏
Vector3 pos = Input.touches[i].position;            // 第i个触摸点的位置
touch.phase == TouchPhase.Ended                     // 触摸结束事件
```

4. 飞机倾斜（沿Z轴正负旋转一定角度）
```c#
transform.Rotate();
```

5. 摄像机跟随
```c#
float heightDamping = 2.0f;                         // 高度变换阻尼
float rotationDamping = 2.0f;                       //绕y轴的旋转中的阻尼参数


Transform target = GameObject.Find("airplane");     // 要跟随的物体
flaot distance = 10.0f;                             // 摄像机和被跟随物体之间的高度间隔

float targetHeight = target.position.y;             // 被跟随物体的高度
float targetRotatez= target.eulerAngles.y;          // 被跟随物体旋转角度

float wantedHeight = targetHeight + distance;       // 待调整高度
float wantedRotation = targetHeight;

float curHeight = transform.position.y;             // 当前高度
float curRotation = transform.eulerAngles.y;        // 当前旋转角度


curRotation = Mathf.LerpAngle(curRotation,wantedRotation,rotationDamping);  // 实际调整的角度
curHeight = Mathf.Lerp(curHeight,wantedHeight,heightDamping);               // 实际调整的高度

transform.position = target.transform.position - Vector3.forward*distance*Quaternion.Euler(0, curRotation, 0) ;
transform.position = new Vector3(transform.position.x,curHeight,transform.position.z);


transform.LookAt(target.transform);                           // 相机注视目标物体
```



