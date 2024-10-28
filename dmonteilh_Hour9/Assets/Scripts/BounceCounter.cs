using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    int count = 0;

    void OnCollisionEnter(Collision other)
    {
        count++;
        Debug.Log(count);
    }
}