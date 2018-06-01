using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color : MonoBehaviour {
    public UnityEngine.Color color;
    public UnityEngine.Color backgroundColor;
    public UnityEngine.Color contentColor;
    string fieldText = "field Text";
    bool bGUIEnabled = true;
    bool buttonEnabled = true;
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnGUI()
    {
        //GUI.color = UnityEngine.Color.yellow;
        GUI.backgroundColor = UnityEngine.Color.red;
        GUI.contentColor = UnityEngine.Color.green;

        //GUI.color = color;
        //GUI.backgroundColor = backgroundColor;

        float screenWidth = Screen.width;
        float screenHeight = Screen.height;

        int nCount = 10;
        float width = screenWidth / nCount;
        float heigh = screenHeight / nCount;


        bGUIEnabled = GUI.Toggle(new Rect(0, 4 * heigh, width, heigh), bGUIEnabled, "ALL Enabled?");
        GUI.enabled = bGUIEnabled;      // 如果 Toggle 被设置为 false ，则以下所有的组件都被禁用！！

        
        GUI.Box(new Rect(0,0, width, heigh),new GUIContent("Hello Box","this is box tooltip"));
        GUI.Label(new Rect(0, heigh, width, heigh), "hello lable");


        //GUI.Button(new Rect(0, 2 * heigh, width, heigh), "hello button");
        fieldText = GUI.TextField(new Rect(0, 3 * heigh, width, heigh), fieldText);  

        buttonEnabled = GUI.Toggle(new Rect(0, 5 * heigh, width, heigh), buttonEnabled && bGUIEnabled, "Button Enabled?");
        GUI.enabled = buttonEnabled;
        GUI.Button(new Rect(0, 2 * heigh, width, heigh), "hello button");

        GUI.Label(new Rect(Screen.width / 10, Screen.height / 5, Screen.width / 5, Screen.height / 10), GUI.tooltip);
        GUI.enabled = true;             // 完了之后，要将GUI激活
        if (GUI.changed)
        {
            Debug.Log("text changed:" + fieldText);
        }


    }
}
