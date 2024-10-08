using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int sum = 22;

        Debug.Log(sum);

        while(sum < 100)
        {
            sum += 2;
            Debug.Log(sum);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
