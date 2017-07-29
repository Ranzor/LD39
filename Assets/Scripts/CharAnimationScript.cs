using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharAnimationScript : MonoBehaviour {

    Animator animator;
	// Use this for initialization
	void Start ()
    {
        animator = GetComponent<Animator>();	
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
		if(Input.GetKey("w"))
        {
            animator.SetBool("IsWalkingUp", true);
            animator.SetBool("IsWalkingDown", false);
            animator.SetBool("IsWalkingLeft", false);
            animator.SetBool("IsWalkingRight", false);
        }
        else if (Input.GetKey("a"))
        {
            animator.SetBool("IsWalkingUp", false);
            animator.SetBool("IsWalkingDown", false);
            animator.SetBool("IsWalkingLeft", true);
            animator.SetBool("IsWalkingRight", false);
        }
        else if (Input.GetKey("s"))
        {
            animator.SetBool("IsWalkingUp", false);
            animator.SetBool("IsWalkingDown", true);
            animator.SetBool("IsWalkingLeft", false);
            animator.SetBool("IsWalkingRight", false);
        }
        else if (Input.GetKey("d"))
        {
            animator.SetBool("IsWalkingUp", false);
            animator.SetBool("IsWalkingDown", false);
            animator.SetBool("IsWalkingLeft", false);
            animator.SetBool("IsWalkingRight", true);
        }
        else
        {
            animator.SetBool("IsWalkingUp", false);
            animator.SetBool("IsWalkingDown", false);
            animator.SetBool("IsWalkingLeft", false);
            animator.SetBool("IsWalkingRight", false);
        }
    }
}
