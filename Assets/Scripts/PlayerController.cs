using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public float speed; 
	public Text countText;
	public Text winText;

	private Rigidbody rb;
	private int count;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		count = 0;
		SetCountText ();
		winText.text = "";
		/*
		GetComponent<Animation>()["Jump"].layer  = 3;
		GetComponent<Animation> () ["Jump"].blendMode = AnimationBlendMode.Additive;
		GetComponent<Animation> () ["Jump"].speed = 0.1f;
//		GetComponent<Animation> () ["Jump"].time = 10000;

		GetComponent<Animation> () ["Jump"].wrapMode = WrapMode.Once;
*/
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
		if (other.gameObject.CompareTag ("Pick Up"))
		{
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText ();
			/*
			var anim = GetComponent<Animation> () ["Jump"];



			//GetComponent.<Animation>().Play("Ithcing");
			//GetComponent.<Animation>().Play("Meow");
			GetComponent<Animation>().Play("Jump",PlayMode.StopAll);
*/
			Animator anim;
			int jumpHash = Animator.StringToHash("Jump");


			// Use this for initialization
				anim = GetComponent<Animator>() ;

			// Update is called once per frame

				float move = Input.GetAxis ("Vertical");
				anim.SetFloat ("Speed", move);

				{
					anim.SetTrigger (jumpHash);
				}

		}
	}

	void SetCountText ()
	{
		countText.text = "Count: " + count.ToString ();
		if (count >= 12)
		{
			winText.text = "You Win!";
		}
	}
}