using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUISelectedGrid : MonoBehaviour {
    public int selGridInt = 0;                                      //声明一个初始值为0的整型变量selGridInt
    public string[] selStrings = new string[] { "Grid 1", "Grid 2", "Grid 3", "Grid 4" };
    //声明一个具有内容的字符型数组
    void OnGUI()                                                    //声明OnGUI方法
    {
        //绘制一个内容为selStrings且当前焦点在第selGridInt上的网格按钮控件
        selGridInt = GUI.SelectionGrid(new Rect(Screen.width / 10, Screen.height / 10,
            Screen.width / 2, Screen.height / 3), selGridInt, selStrings, 12);
        Debug.Log(selGridInt);
    }
}
