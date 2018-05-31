using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothFollow : MonoBehaviour {
    public GameObject target;
    public float distance = 10.0f;      //与目标对象的距离
    public float height = 5.0f;         //与目标对象的高度差
    public float heightDamping = 2.0f;  //高度变化中的阻尼参数
    public float rotationDamping = 3.0f;//绕y轴的旋转中的阻尼参数

                                        // Use this for initialization
    void Start () {
        target = GameObject.FindWithTag("airplane");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void LateUpdate()
    {
        if (target == null)
        {
            return;
        }

        
        float targetrotatedY = target.transform.eulerAngles.y;          // 目标演y轴的旋转角度
        float targetHeight = target.transform.position.y + height;      // 相机期望的高度

        float curRotatedY = transform.eulerAngles.y;                    // 当前旋转角度
        float curHeight = transform.position.y;                         // 相机当前高度

        targetrotatedY = Mathf.LerpAngle(curRotatedY, targetrotatedY, rotationDamping * Time.deltaTime);
        targetHeight = Mathf.Lerp(curHeight, targetHeight, heightDamping * Time.deltaTime);

        var currentRotation = Quaternion.Euler(0, targetrotatedY, 0);
        transform.position = target.transform.position;
        transform.position -= currentRotation * Vector3.forward * distance;
        transform.position = new Vector3(transform.position.x, targetHeight, transform.position.z); ;
        transform.LookAt(target.transform);
    }
}
