using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPScamers : MonoBehaviour
{
    float speed = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        { transform.position += speed * transform.forward * Time.deltaTime;
        
        }
    }
}
