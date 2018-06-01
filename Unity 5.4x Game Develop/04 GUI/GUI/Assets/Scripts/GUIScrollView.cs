using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIScrollView : MonoBehaviour {

    public Vector2 scrollPosition = Vector2.zero;                               //声明一个初始值为（0，0）的坐标scrollPosition
    void OnGUI()
    {                                                               //声明OnGUI方法
        scrollPosition = GUI.BeginScrollView(                                   //在屏幕的自定义区域内创建一个滚动视图
            new Rect(0, 0, Screen.width, Screen.height),
            new Vector2(Screen.width/2, Screen.height/2), new Rect(0, 0, Screen.width*2, Screen.height*2),false,false);
        GUI.Button(new Rect(0, 0, 100, 20), "Top-left");                        //在屏幕自定义区域内分别创建4个按钮
        GUI.Button(new Rect(120, 0, 100, 20), "Top-right");
        GUI.Button(new Rect(0, 120, 100, 20), "Bottom-left");
        GUI.Button(new Rect(Screen.width - 100, Screen.height - 120, 100, 120), "Bottom-right");
        GUI.Button(new Rect(0, Screen.height*2, 100, 20), "Bottom-left");       // 只有在 viewRect 范围内的才会显示
        GUI.EndScrollView();                                                    //撤销这个滚动视图
    }
}
