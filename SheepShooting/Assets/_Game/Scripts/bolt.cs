using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bolt : MonoBehaviour {
    public float speed;
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            //Debug.Log("Destroy" + other.gameObject.name);
            Destroy(other.gameObject);
            //Debug.Log(gameObject.name);
            Destroy(gameObject);
        }
    }
}
