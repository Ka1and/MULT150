using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;
    public int numberOfLamps = 10;
    public float distanceBetweenLamps = 2.0f;

    void Start()
    {
        for (int i = 0; i < numberOfLamps; i++)
        {
            Vector3 spawnPosition = new Vector3(i * distanceBetweenLamps, 0, 0);
            Instantiate(prefab, spawnPosition, Quaternion.identity);
        }
    }

    void Update()
    {
    if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
