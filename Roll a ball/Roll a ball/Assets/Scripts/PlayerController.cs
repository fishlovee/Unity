using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float speed;
	public Text countText;

	private Rigidbody rb;
	private int count;


	// Use this for initialization
	void Start () {
		count = 0;
		rb = GetComponent<Rigidbody> ();
		UpdateCountText ();
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rb.AddForce (movement * speed);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("Pick Up")) {
			other.gameObject.SetActive (false);
			count++;
			UpdateCountText ();
		}
	}

	void UpdateCountText()
	{
		countText.text = "Count:" + count.ToString ();
	}
}
