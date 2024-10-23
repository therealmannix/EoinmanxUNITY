using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class edAnimScript : MonoBehaviour
{
    float speed=1;
    Animator edAnimator;


    // Start is called before the first frame update
    void Start()
    {
        edAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        edAnimator.SetBool("isWalking", false);

        if (Input.GetKey(KeyCode.W))
        {
            //make ED walk in animations and move foward
            edAnimator.SetBool("isWalking", true);
            transform.position += speed * transform.forward * Time.deltaTime;

        }


    }

    private static void SetBool(string v1, bool v2)
    {
        throw new NotImplementedException();
    }
}
