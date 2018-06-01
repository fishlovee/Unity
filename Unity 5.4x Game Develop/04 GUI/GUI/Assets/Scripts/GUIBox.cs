using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIBox : MonoBehaviour {
    public Texture BoxTexture;      // Drag a Texture onto this item in the Inspector

    GUIContent content;

    void Start()
    {
        content = new GUIContent("This is a box", BoxTexture, "This is a tooltip");
    }

    void OnGUI()
    {
        GUI.Box(new Rect(Screen.width/5, Screen.height/5, Screen.width/5, Screen.height/5), content);
        GUI.Label(new Rect(Screen.width / 10, Screen.height / 10, Screen.width / 2, Screen.height / 5), GUI.tooltip);
    }
}
