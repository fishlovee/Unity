using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class Restart : MonoBehaviour {
    

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Click()
    {
        Debug.Log("Restart Button Clicked!");
        SceneManager.LoadScene("MainScene");
        gameObject.SetActive(false);
    }

}
