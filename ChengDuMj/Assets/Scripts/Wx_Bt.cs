using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Wx_Bt : MonoBehaviour {
    private Button loginButton;
    // Use this for initialization
    void Start () {
        loginButton = gameObject.GetComponent<Button>();
        loginButton.onClick.AddListener(OnClick);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnClick()
    {
        Debug.Log("WxBt OnClick");
        StartCoroutine(Login());
        // load login 
    }

    IEnumerator Login()
    {
        Account acount = Account.GetAccount();
        SceneManager.LoadScene("hall");
        yield return acount;
    }
}
