using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseXvalue = Input.GetAxis("Mouse X");
        float mouseYvalue = Input.GetAxis("Mouse Y");

        if (mouseXvalue < 0)
        {
            transform.Rotate(0f, -.5f, 0f);
        }

        if (mouseXvalue > 0)
        {
            transform.Rotate(0f, .5f, 0f);
        }

        if (mouseYvalue > 0)
        {
            transform.Rotate(-.5f, 0f, 0f);
        }

        if (mouseYvalue < 0)
        {
            transform.Rotate(.5f, 0f, 0f);
        }
    }
}
