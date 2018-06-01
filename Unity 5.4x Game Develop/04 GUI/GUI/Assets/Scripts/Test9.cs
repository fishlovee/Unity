using UnityEngine;
using System.Collections;                                                       //导入系统类

public class Test9 : MonoBehaviour
{                                            //声明一个类Test9，并继承类MonoBehaviour
    public static int guiDepth = 0;                                             //声明一个初始值为0的静态整型变量guiDepth
    void OnGUI()
    {                                                               //声明OnGUI方法
        GUI.depth = guiDepth;                                                   //将GUI.depth设置为guiDepth
        if (GUI.RepeatButton(new Rect(Screen.width / 10, Screen.height / 10,    //绘制一个名为GoBack的RepeatButton
            Screen.width / 5, Screen.height / 5), "GoBack9"))
        {                   //若持续按下按钮GoBack，guiDepth变量置为1
            guiDepth = 1;
            Test10.guiDepth = 0;                                                //将Test10.guiDepth的值置为0
        }
    }

}

