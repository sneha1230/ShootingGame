using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPositions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("RandomPosition", 2.0f, 2.0f);
    }
    private void RandomPosition()
    {
        float x = Random.Range(-4.0f, +4.0f);
        float z = Random.Range(-4.0f, 4.0f);
        Vector3 pos = new Vector3(x, 1.0f, z);
        transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
