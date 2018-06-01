http://baijiahao.baidu.com/s?id=1594078276280949280&wfr=spider&for=pc

### GUI主要方法

> 这里介绍的的所有方法都为GUI类的静态方法

**1. BeginGroup**
> 和 EndGroup 配套使用，其内所有组件视为一体，并拥有独立坐标系，左上角为(0,0)   

**2. BeginScrollView**
> EndScrollView 配套使用，position 定义控件自身位置，scrollPosition 定义初始时滚动条的位置，viewRect 定义可滚动范围，  
> alwaysShowHorizontal 和 alwaysShowVertical 缺省为true，如果为false， 则只在 定义初始时滚动条的位置，viewRect 比   
> position 宽时显示滚动条

**3. Box**
> https://docs.unity3d.com/ScriptReference/GUI.Box.html  
> box 可以填充纹理、文字，指定box的样式，以及添加 tooltip  

**4. Button**
> https://docs.unity3d.com/ScriptReference/GUI.Button.html  
> Make a single press button. The user clicks them and something happens immediately.  


**5. BringWindowToBack**
> https://docs.unity3d.com/ScriptReference/GUI.BringWindowToBack.html  
> Bring a specific window to back of the floating windows.  


~~~c#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIBringWindowBack : MonoBehaviour {
    private Rect window1 = new Rect(0, 0, Screen.width / 2, Screen.height / 2);
    private Rect window2 = new Rect(100, 100, Screen.width / 2, Screen.height / 2);

    private void OnGUI()
    {
        window1 = GUI.Window(1, window1, Func1, "window1");
        window2 = GUI.Window(2, window2, Func2, "window2");
    }

    void Func1(int id)
    {
        if (GUI.Button(new Rect(20,20,100,100),"put back"))
        {
            GUI.BringWindowToBack(id); // 点击时，将自身层次置后
        }
    }

    void Func2(int id)
    {
        if (GUI.Button(new Rect(0, 0, 100, 100), "put back"))
        {
            GUI.BringWindowToBack(id);
        }
    }
}
~~~


**6. BringWindowToFront**
> 同 BringWindowToBack 

**7. DragWindow**
> https://docs.unity3d.com/ScriptReference/GUI.DragWindow.html  
> 使一个窗口可拖动，在创建window时为 GUI.Window 的第三个参数提供创建拖拽窗口函数 
```c#
    private Rect rect = new Rect(100,100,800,1000);

    private void OnGUI()
    {
        rect = GUI.Window(0, rect, Func1, "drag window");
    }

    void Func1(int id)
    {
        GUI.DragWindow(rect);
        GUI.Button(new Rect(150, 150, 100, 20), "Can't drag me"); // 可以拖动button
    }

    void Func2(int id)
    {
        GUI.Button(new Rect(150, 150, 100, 20), "Can't drag me"); // 不可以拖动button
        GUI.DragWindow(rect);
    }
```


**8. SetNextControlName**
> 设置下一控件的名字，可以通过 GetNameOfFocusedControl 和 FocusControl 来判断或设置对应名字的控件
~~~c#
    public string login = "username";
    public string login2 = "no action here";

    void OnGUI()
    {
        GUI.SetNextControlName("user");
        login = GUI.TextField(new Rect(10, 10, 130, 20), login);

        GUI.SetNextControlName("login");
        login2 = GUI.TextField(new Rect(10, 40, 130, 20), login2);
        if (/*Event.current.Equals(Event.KeyboardEvent("return")) &&*/ GUI.GetNameOfFocusedControl() == "user")
            Debug.Log("user");

        if (GUI.Button(new Rect(Screen.width / 10, Screen.height * 2 / 5, Screen.width / 6, Screen.height / 10), "Move Focus"))
            GUI.FocusControl("login");

        if (GUI.Button(new Rect(150, 10, 50, 20), "Login"))
            Debug.Log("Login");
    }
~~~


**9.GUI.PasswordField**
```c#
pwd = GUI.PasswordField(new Rect(200, 200, 200, 100), pwd, '*',25);
```

**10. RepeatButton**
> 当按住时，持续返回true

**11. SelectionGrid**
> 创建网格按钮
```c#
    public int selGridInt = 0;                                                              //声明一个初始值为0的整型变量selGridInt
    public string[] selStrings = new string[] { "Grid 1", "Grid 2", "Grid 3", "Grid 4" };   //声明一个具有内容的字符型数组
    
    void OnGUI()                                                    
    {
        //绘制一个内容为selStrings且当前焦点在第selGridInt上的网格按钮控件
        selGridInt = GUI.SelectionGrid(new Rect(Screen.width / 10, Screen.height / 10,
            Screen.width / 2, Screen.height / 3), selGridInt, selStrings, 12);
        Debug.Log(selGridInt);
    }
```
