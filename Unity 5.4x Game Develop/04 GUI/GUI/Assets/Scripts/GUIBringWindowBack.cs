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
