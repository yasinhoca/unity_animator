using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wlk : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("yuru", true);
            animator.SetBool("dur", false);
        }
        else { 
            animator.SetBool("yuru", false);
            animator.SetBool("dur", true);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            animator.SetBool("zipla", true);
            animator.SetBool("dur", false);
        }
        else
        {
            animator.SetBool("zipla", false);
            animator.SetBool("dur", true);
        }
    }
}
