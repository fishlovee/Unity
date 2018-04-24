### Input 简介
> Input 是Unity提供的输入系统接口。使用这个类能够读取输入管理器设置的按键，以及访问移动设备的多点触控或加速感应数据。

#### Input.GetAxis
> 想要读取轴向使用Input.GetAxis方法获取下列默认轴： "Horizontal" 和"Vertical" 映射于控制杆、A、W、S、D和箭头键（方向键）。 "Mouse X" 和"Mouse Y" 映射于鼠标,"Fire1", "Fire2" "Fire3"映射于键盘的Ctrl、Alt、Cmd键和鼠标中键或控制器的按钮。新的输入设置可以使用输入管理器来添加。


#### Input.GetAxis() 和 Input.GetButton()
1. Input制作某种运动行为可以使用Input.GetAxis方法，它能够返回来自键盘、控制器或鼠标平缓并且可以设置的输入结果。
2. 使用Input.GetButton方法只用于像事件之类的动作。不要将它用于移动动作。
3. Input.GetAxis方法可以使脚本代码更简洁。


#### 注意：
> Note also that the Input flags are not reset until "Update()", so its suggested you make all the Input Calls in the Update Loop. 
> 每次输入在"Update()"之前不会再更新，所以建议你将所有的输入调用都写在Update方法中。（Update循环中）

#### Input.touches
> Input.touches属性集合访问在最近一帧中触摸在屏幕上的每一根手指的状态数据。当设备移动时，它们的加速感应器硬件将报告它们在三维空间中沿着三个主轴的线性加速变化数据。你可以使用这些数据检测设备当前的移动方向（相对于地面）和突然间的方向改 变。

> Acceleration along each axis is reported directly by the hardware as G-force values. A value of 1.0 represents a load of about +1g along a given axis while a value of -1.0 represents -1g. If you hold the device upright (with the home button at the bottom) in front of you, the X axis is positive along the right, the Y axis is positive directly up, and the Z axis is positive pointing toward you. 


|函数|说明|
|:--|:--|
|GetAccelerationEvent|Returns specific acceleration measurement which occurred during last frame (Does not allocate temporary variables).返回上一帧发生的指定的加速度测量（不允许分配临时变量）|
|GetTouch|Returns object representing status of a specific touch (Does not allocate temporary variables).返回一个存放触摸信息的对象（不允许分配临时变量）。 |

