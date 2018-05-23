using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BloodControl : MonoBehaviour {
    public Button subButton;
    public Button addButton;
    public RectTransform redImg;
    public RectTransform greenImg;
    private float blood;
    private float maxWidth = 100.0f;
    private Vector3 pos;


	// Use this for initialization
	void Start ()
    {
        blood = 100.0f;
        addButton.onClick.AddListener(delegate { AddBlood(); });
        subButton.onClick.AddListener(delegate { ReduceBlood(); });
        pos = redImg.position;
    }
	
	// Update is called once per frame
	void Update ()
    {
        float redWidth = Mathf.Lerp(0, maxWidth, blood / maxWidth);
        redImg.position = new Vector3(pos.x - (maxWidth - blood) / 2, pos.y, pos.z);
        redImg.sizeDelta = new Vector2(redWidth, redImg.rect.height);
	}

    private void AddBlood()
    {
        if (blood < 100.0f)
        {
            blood = blood + 1 > 100 ? 100 : blood + 1;
        }
        Debug.Log(blood);
    }

    private void ReduceBlood()
    {
        if (blood > 0)
        {
            blood = blood - 1 > 0 ? blood - 1 : 0;
        }
        Debug.Log(blood);
    }
}
