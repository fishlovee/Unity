using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIDragWindow : MonoBehaviour {
    private Rect rect = new Rect(100,100,800,1000);

    private void OnGUI()
    {
        rect = GUI.Window(0, rect, Func1, "drag window");
    }

    void Func1(int id)
    {
        GUI.DragWindow(rect);
        GUI.Button(new Rect(150, 150, 100, 20), "Can't drag me"); //
        //GUI.DragWindow(rect);
    }
}
