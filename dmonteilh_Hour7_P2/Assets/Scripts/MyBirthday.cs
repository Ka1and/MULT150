using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for(int d = 1; d <= 30; d++)
        {
            if (d == 9)
            {
                Debug.Log("Its my birthday");
            }
            else
            {
                Debug.Log(d);
            }

        }  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}