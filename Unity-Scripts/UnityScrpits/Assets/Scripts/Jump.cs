using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

    enum EN_JUMP_DIR
    {
        EN_JUMP_NONE,
        EN_JUMP_UP,
        EN_JUMP_DOWN,
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (eJump != EN_JUMP_DIR.EN_JUMP_DOWN && Input.GetKeyDown(KeyCode.UpArrow))
        {
            eJump = EN_JUMP_DIR.EN_JUMP_UP;
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            eJump = EN_JUMP_DIR.EN_JUMP_DOWN;
        }


        switch (eJump)
        {
            case EN_JUMP_DIR.EN_JUMP_NONE:
                break;
            case EN_JUMP_DIR.EN_JUMP_UP:
                CubeJump();
                break;
            case EN_JUMP_DIR.EN_JUMP_DOWN:
                CubeDown();
                break;
            default:
                break;
        }
    }

    private void FixedUpdate()
    {
    }

    void CubeJump()
    {
        if (transform.position.y >= highMax)
        {
            eJump = EN_JUMP_DIR.EN_JUMP_DOWN;
        }
        else
        {
            //transform.Translate(new Vector3(0, 0.1F * Time.fixedDeltaTime, 0));
            transform.position = new Vector3(transform.position.x, transform.position.y + speed * Time.fixedDeltaTime, 0);
        }
    }

    void CubeDown()
    {
        if (transform.position.y <= 0.5f)
        {
            eJump = EN_JUMP_DIR.EN_JUMP_NONE;
        }
        else
        {
            //transform.Translate(new Vector3(0, -0.1F * Time.fixedDeltaTime, 0));
            transform.position = new Vector3(transform.position.x, transform.position.y - speed * Time.fixedDeltaTime, 0);
        }
    }

    public float speed = 10.01f;
    public float highMax = 5.0f;
    private EN_JUMP_DIR eJump;
}
