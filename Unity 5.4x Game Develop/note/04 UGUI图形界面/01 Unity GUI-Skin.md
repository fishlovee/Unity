### 4.1 GUI 图形界面系统

**图形位置**
> GUI 绘制位置是通过坐标定位的，以屏幕左上角的坐标为(0,0)，屏幕右下角的坐标为(Screen.width,Screen.height)，单位为像素  

**运行时加载不同的GUI.skin**
1. 创建5个GUI.skin
2. 为每个skin的button添加不同的背景图片
3. 创建脚本 ChangeSkin.cs ，加载到camera，添加以下脚本并将不同的skin给到定义的skin变量
~~~c#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSkin : MonoBehaviour {
    public GUISkin[] skins;
    private int index = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space))
        {
            index++;
            if (index >= skins.Length)
            {
                index = 0;
            }
        }
	}

    private void OnGUI()
    {
        GUI.skin = skins[index];
        if (GUI.Button(new Rect(Screen.width/3,Screen.height/3,Screen.width/3,Screen.height/3),"我是button"))
        {
            Debug.Log("Button");
        }
    }
}

~~~