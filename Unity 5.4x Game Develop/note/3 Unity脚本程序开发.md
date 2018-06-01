### Unity 中脚本注意事项
1. 类名必须和文件名匹配
> C#脚本中类名必须和文件名匹配，否则挂载到游戏对象时，控制台会报错

2. 使用Awake或Start方法初始化（尽量避免使用构造函数）
> 用于初始化脚本的代码必须置于 Awake 或 Start 方法中，而不是使用构造函数。Unity 仍会自动调用构造函数，但是无法预计  
> 何时调用构造函数，它或许会被预制体或未激活的游戏对象所调用。在单一模式下也可能会带来类似随机的空引用异常。 因此尽  
> 量避免使用构造函数初始化。事实上，没必要在继承自 MonoBehavior 类的构造函数中写任何代码。

3. 调试
> Unity 可以使用 Print 和 Debug.Log() 来打印信息，但是 Print 只能在 mono 类中使用，所以一般情况最好使用 Debug.Log()  
> 同时，也可以使用 Debug.Log.Warning() 和 Debug.LogError() 手机警告和错误信息。  
> Unity 可以通过 Debug.Break 设置断点。如果想查看特定情况发生时对象属性的变化，用断点可以快速完成。

### Unity脚本基础语法
1. 常用操作
> Unity 中很多对游戏对象的操作都是通过在脚本中修改对象的 Transform 和 Rigidbody 属性来实现的。在脚本编写完成后，直接将  
> 脚本挂在到游戏对象上即可实现相应操作。  

~~~c#
this.transform.Rotate(20,0,0);      // 绕X轴旋转20°
this.transform.Translate(0,0,1);    // 实现物体移动发一个单位长度
~~~

> Rotate 和Translate 函数还有第四个参数，用来表示是相对世界轴还是自身轴变换，默认为 Space.World 表示相对世界轴变换,  
> Space.Self 表示相对自身轴变换。  

> deltaTime ： 只读。用来表示上一次调用Update或者FixedUpdate方法到现在的时间。如果想均匀的旋转一个物体，不考虑帧速率的情况  
> 可以乘以 Time.deltaTime。  

> 如果涉及刚体，则可以在 FixedUpdate 方法里面实现，将 Time.deltaTime 替换为 Time.fixedDeltaTime 即可。  

### 访问游戏对象组件
> 如果想通过挂在在游戏对象上的脚本代码获得游戏对象上的对应组件及其属性，可以通过变量名。  
> 如果想查看所有的预定义成员变量，可以查看  Component 、 Behaviour 和 MonoBehaviour 类的文档 
> 在 Unity 中，附加到游戏对象上的组件可以通过 Getcomponent 方法获取、。
> 通过 find 和 getcomponet 获取子对象或组件  
> 通过名字或标签获取游戏对象  FindWithTag/Find  


### 向量

