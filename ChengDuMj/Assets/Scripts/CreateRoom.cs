using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CreateRoom : MonoBehaviour {
    private Button createButton;
    private Button cancelButton;
    private Toggle zipaiToggle;
    private Toggle huapaiToggle;

    // Use this for initialization
    void Start () {
        createButton = transform.Find("Create").GetComponent<Button>();
        cancelButton = transform.Find("Cancel").GetComponent<Button>();

        createButton.onClick.AddListener(OnCreate);
        cancelButton.onClick.AddListener(OnCancel);

        zipaiToggle = transform.Find("CardOp").Find("ZiOp").GetComponent<Toggle>();
        huapaiToggle = transform.Find("CardOp").Find("HuaOp").GetComponent<Toggle>();

        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCreate()
    {
        PubDefs.Print("创建房间，加载游戏");
        Param.zpCheck = zipaiToggle.isOn;
        Param.hpCheck = huapaiToggle.isOn;
        StartCoroutine(LoadGame());
    }

    void OnCancel()
    {
        gameObject.SetActive(false);
        PubDefs.Print("取消创建房间");
    }

    IEnumerator LoadGame()
    {
        SceneManager.LoadScene("game");
        Account acount = Account.GetAccount();
        yield return acount;
    }
}
