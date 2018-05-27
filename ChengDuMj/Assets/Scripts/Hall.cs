using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hall : MonoBehaviour {
    private Button createLowBt;
    private Button createMidBt;
    private Button createHighBt;

	// Use this for initialization
	void Start () {
        PubDefs.Print("加载大厅");
        createLowBt = transform.Find("Create_low_button").GetComponent<Button>();
        createMidBt = transform.Find("Create_mid_button").GetComponent<Button>();
        createHighBt = transform.Find("Create_high_button").GetComponent<Button>();

        createLowBt.onClick.AddListener(OnLowClicked);
        createMidBt.onClick.AddListener(OnMidClicked);
        createHighBt.onClick.AddListener(OnHighCilcked);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnLowClicked()
    {
        PubDefs.Print("创建初级房");
        transform.Find("create_room_panel").gameObject.SetActive(true);
    }

    void OnMidClicked()
    {
        PubDefs.Print("创建中级房");
    }

    void OnHighCilcked()
    {
        PubDefs.Print("创建高级房");
    }
}
