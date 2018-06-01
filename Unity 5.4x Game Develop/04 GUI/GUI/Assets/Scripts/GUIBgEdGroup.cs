using UnityEngine;
using System.Collections;

public class GUIBgEdGroup : MonoBehaviour
{
    void OnGUI()
    {                                                       //声明OnGUI方法
        GUI.BeginGroup(new Rect(Screen.width / 2 - 200,                 //在屏幕自定义区域内创建一个组
            Screen.height / 2 - 100, 400, 200));
        GUI.Box(new Rect(0, 0, 400, 200),                               //在自定义区域内创建一个Box控件
            "This box is now centered!");
        GUI.Button(new Rect(0, 0, 50, 50), "Button");
        //Box控件用于显示的内容
        GUI.EndGroup();                                                 //结束这个组
    }

}
