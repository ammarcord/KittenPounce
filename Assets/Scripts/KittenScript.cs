using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KittenScript : MonoBehaviour {

/*
from tutorial "Moving the player"
	void fixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
	}
*/
/*
Does this work?
from tutorial "Animator Scripting"
*/
	/*
	Animator anim;
	int jumpHash = Animator.StringToHash("Jump");


	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>() ;
	}
	*/
	// Update is called once per frame
/*
	void Update_unused ()
	{
		float move = Input.GetAxis ("Vertical");
		anim.SetFloat ("Speed", move);

		if(Input.GetKeyDown(KeyCode.Space))
		{
			anim.SetTrigger (jumpHash);
		}
	}
*/
}
