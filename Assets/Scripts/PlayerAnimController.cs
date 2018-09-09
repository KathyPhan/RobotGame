using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimController : MonoBehaviour {

   static Animator anim;


    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetAxis("Horizontal") != 0)
        {
           anim.SetBool("isWalking", true);
        }
        else
       {
         anim.SetBool("isWalking", false);
        }


        if (Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("Active");
        }

        if(Input.GetButtonDown("Jump"))
        {
            anim.SetTrigger("isJumping");
        }
    }
}
