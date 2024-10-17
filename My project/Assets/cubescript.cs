using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubescript : MonoBehaviour
{
    private int turningSpeed = 5;
    private int runningSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        transform.position += new Vector3(0, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))

        {
            transform.position += new Vector3(0, 1, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0, 1, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(transform.up, turningSpeed *  Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(transform.up, turningSpeed *  Time.deltaTime);
        
        }
        if(Input.GetKey(KeyCode.Space))

        {       transform.position += runningSpeed * transform.up * Time.deltaTime;
        
        }
    }
}

         


