using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class set_ani_bool : MonoBehaviour
{
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    //{
    //    if(Input.GetKey("w")){
    //        animator.SetBool("Run", true);
    //    }else if(Input.GetKey("s")){
    //        animator.SetBool("Run", true);
    //    }else if(Input.GetKey("a")){
    //        animator.SetBool("Run", true);
    //    }else if(Input.GetKey("d")){
    //        animator.SetBool("Run", true);
    //    }else{
    //        animator.SetBool("Run", false);
    //    }        
    //}
    {
        if(Input.GetKey("w") | Input.GetKey("s") | Input.GetKey("a") | Input.GetKey("d")){
            animator.SetBool("Run", true);
        }else{
            animator.SetBool("Run", false);
        }        
    }
}
