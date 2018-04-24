// file:///C:/Program%20Files/Unity/Editor/Data/Documentation/en/ScriptReference/Transform.html
// https://docs.unity3d.com/Manual/class-Transform.html
### Transform 类

##### transform 组件决定了场景中所以物体的位置、旋转角度、缩放大小，每个游戏对象都有一个 transform 

#### 属性及作用
1. Position	：Position of the Transform in X, Y, and Z coordinates.
2. Rotation	：Rotation of the Transform around the X, Y, and Z axes, measured in degrees.
3. Scale	：Scale of the Transform along X, Y, and Z axes. Value “1” is the original size (size at which the object was imported).


#### 继承变量
|||
|:----|:----|
|gameObject |组件所附加到的游戏对象，所以组件都会被附加到一个游戏对象上
|tag	|游戏对象的tag
|transform	|The Transform attached to this GameObject.
|hideFlags	|Should the object be hidden, saved with the scene or modifiable by the user?
|name	|The name of the object.


#### 公共函数
| 函数 | 说明|
|:---- | :----|
|Find	| Finds a child by name and returns it|
|GetChild| Returns a transform child by index.|
|LookAt|Rotates the transform so the forward vector points at /target/'s current position.
|RotateAround	|Rotates the transform about axis passing through point in world coordinates by angle degrees.
|SetParent	|Set the parent of the transform.
|Translate	|Moves the transform in the direction and distance of translation.
|BroadcastMessage|Calls the method named methodName on every MonoBehaviour in this game object or any of its children
|CompareTag	|Is this game object tagged with tag ?
|Destroy|	Removes a gameobject, component or asset.
|DestroyImmediate	|Destroys the object obj immediately. You are strongly recommended to use Destroy instead.
|Instantiate|	Clones the object original and returns the clone.


#### Destroy 和 DestroyImmediate 的区别
1. destroy 不会立马销毁该物体，  DestroyImmediate 会立马销毁该物体
2. destroy 由于不立马销毁该物体，因此游戏对象原本的计数不会减少，也不能立马检测到游戏对象是否销毁，而 DestroyImmediate 会立马造成游戏对象的销毁，计数的减少，销毁也可以立马检测到
3. 一般推荐使用 destroy 


#### 操作符
|操作符|说明|
|:----|:----|
|bool|	Does the object exist?
|operator !=	|Compares if two objects refer to a different object.
|operator ==	|Compares two object references to see if they refer to the same object.



### 使用实例

#### 1.跟随移动 LookAt


