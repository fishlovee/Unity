using UnityEngine;
using System.Collections;                       //导入系统类

public class Test5 : MonoBehaviour
{
    public bool allOptions = true;              //声明一个初始值为true的布尔型变量allOptions
    public bool extended1 = true;               //声明一个初始值为true的布尔型变量extended1
    public bool extended2 = true;               //声明一个初始值为true的布尔型变量extended2
    void OnGUI()
    {                               //声明OnGUI方法
                                    //在自定义区域内绘制一个名为Edit All Options的开关，其初始状态为allOptions
        allOptions = GUI.Toggle(new Rect(0, 0, Screen.width / 5,
            Screen.height / 10), allOptions, "Edit All Options");
        GUI.enabled = allOptions;               //将allOptions的值赋给enabled组件
                                                //分别在各个自定义的区域内绘制两个开关
        extended1 = GUI.Toggle(new Rect(Screen.width / 10, Screen.height / 10,
            Screen.width / 5, Screen.height / 10), extended1, "Extended Option1");
        extended2 = GUI.Toggle(new Rect(Screen.width / 10, Screen.height / 5,
           Screen.width / 5, Screen.height / 10), extended1, "Extended Option2");
        GUI.enabled = true;                     //将enabled组件的值设置为true
                                                //在自定义的区域绘制一个名为ok的按钮，并判断是否被按下
        if (GUI.Button(new Rect(0, Screen.height * 3 / 10, Screen.width / 3, Screen.height / 10), "ok"))
            print("user clicked ok");
    }
}
