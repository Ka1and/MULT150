using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreetLightController : MonoBehaviour
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
        if(Input.GetKeyDown(KeyCode.S))
        {
            animator.SetTrigger("Rotate");
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetTrigger("Rescale");
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("Reposition");
        }
    }
}
