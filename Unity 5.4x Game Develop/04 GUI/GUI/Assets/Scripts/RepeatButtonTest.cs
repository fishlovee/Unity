using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatButtonTest : MonoBehaviour {
    private int times = 0;
    private int buttonTimes = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;

        int nCount = 10;
        float width = screenWidth / nCount;
        float heigh = screenHeight / nCount;

        if (GUI.RepeatButton(new Rect(0,0,width,heigh),"repeatButton"))
        {
            times++;
            Debug.Log("repeatbutton is hold" + times);
        }

        if (GUI.Button(new Rect(0, heigh, width, heigh), "button"))
        {
            buttonTimes++;
            Debug.Log("repeatbutton is hold" + buttonTimes);
        }
    }
}
