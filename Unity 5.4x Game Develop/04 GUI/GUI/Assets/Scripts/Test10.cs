using UnityEngine;
using System.Collections;                                           //导入系统类

public class Test10 : MonoBehaviour
{                               //声明一个类Test10，并继承类MonoBehaviour
    public static int guiDepth = 1;                                 //声明一个初始值为1的静态整型变量guiDepth
    void OnGUI()
    {                                                   //声明OnGUI方法
        GUI.depth = guiDepth;                                       //将GUI.depth设置为guiDepth
        if (GUI.RepeatButton(new Rect(Screen.width / 5, Screen.height / 5, Screen.width / 5, Screen.height / 5), "GoBack10"))
        {
            //绘制一个名为GoBack的RepeatButton
            guiDepth = 1;                                           //若持续按下按钮GoBack，guiDepth变量置为1
            Test9.guiDepth = 0;                                     //Test9.guiDepth的值置为0
        }
    }

}
