using System.Collections;
using System.Collections.Generic;
using UnityEngine;


enum EN_MOUSE  
{
    EN_MS_LEFT = 0,
    EN_MS_RIGHT = 1,
    EN_MS_MIDDLE = 2,
}

public class FlightControl : MonoBehaviour {
    private Transform m_transform;
    public float speed = 1.0f;
    public float rotateY = 45.0f;   // 旋转速率
    public float rotateZ = 45.0f;   // 点击屏幕时，机身倾斜角度
    private float screenWidth;
    private float rotateDegreeZ;    // 
    public float maxRotated = 145.0f;
    public float quickBalanceRotate = 45.0f;
    private float adjustDelta = 2.0f;

	// Use this for initialization
	void Start () {
        m_transform = transform;
        screenWidth = Screen.width;
	}
	
	// Update is called once per frame
	void Update () {
        m_transform.Translate(new Vector3(0, 0, Time.deltaTime * speed));               // 向前移动
        GameObject.Find("propeller").transform.Rotate(0, rotateZ * Time.deltaTime * 10,0);     // 旋转螺旋桨

        rotateDegreeZ = transform.eulerAngles.z;                            // 机身倾斜角度

        // 点击左键
        if (Input.GetMouseButton((int)EN_MOUSE.EN_MS_LEFT))
        {
            Vector3 pos = Input.mousePosition;
            int nDir = pos.x < screenWidth / 2?1:-1;   // 1向左偏移，-1向右
            if (rotateDegreeZ <= maxRotated || rotateDegreeZ >= (360 - maxRotated) )
            {
                m_transform.Rotate(0, 0, rotateY * Time.deltaTime * nDir, Space.Self);   // 机身倾斜
            }
            m_transform.Rotate(0, -1*rotateZ * Time.deltaTime * nDir, 0,Space.World); // 机身转弯
        }
        else //if (Input.GetMouseButtonUp((int)EN_MOUSE.EN_MS_LEFT))
        {
            BackToBalance();   // 恢复机身
        }
	}

    /// <summary>
    /// 恢复平衡
    /// </summary>
    void  BackToBalance()
    {
        int nFlag = rotateDegreeZ > 180 ? 1 : -1;
        if (rotateDegreeZ <= adjustDelta || (360 - rotateDegreeZ) <= adjustDelta)
        {
            transform.Rotate(0, 0, nFlag * Time.deltaTime);
        }
        else
        {
            transform.Rotate(0, 0, rotateZ * Time.deltaTime * nFlag);
        }
    }
}
