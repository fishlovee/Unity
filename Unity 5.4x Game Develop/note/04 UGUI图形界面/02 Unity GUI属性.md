### GUI颜色
* GUI.color： 可以改变全局控件文本颜色
* GUI.backgroundColor: 改变控件背景颜色
* GUI.contentColor:对控件文本进行着色
* GUI.changed:判断GUI是否有改变
* GUI.enabled:用于激活或禁止图形界面组件
* GUI.toolTip:toolTip用于在鼠标或键盘焦点获取时提示指定信息，全局、只读。当离开控件时恢复默认。


~~~c#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color : MonoBehaviour {
    public UnityEngine.Color color;

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnGUI()
    {
        GUI.color = UnityEngine.Color.yellow;
        float width = Screen.width;
        float height = Screen.height;

        GUI.Box(new Rect(0,0,width/3,height/3),"Hello Box");
        GUI.Label(new Rect(0, height / 3, width, height/3), "hello lable");
        GUI.Button(new Rect(0, 2 * height / 3, width, height / 3), "hello button");


        //GUI.Label(new Rect(Screen.width / 10, Screen.height / 10, Screen.width / 5, Screen.height / 10), "Hellow World!");
        //GUI.Box(new Rect(Screen.width / 10, Screen.height / 5, Screen.width / 5, Screen.height / 5), "A Box");
        //GUI.Button(new Rect(Screen.width / 10, Screen.height / 2, Screen.width / 5, Screen.height / 10), "A Button");
    }
}
~~~