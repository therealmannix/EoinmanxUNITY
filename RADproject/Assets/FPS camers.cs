using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPScamers : MonoBehaviour
{
    public GameObject KnifeCloneTemplate;
    float speed = 3;
    private object nsform;
    private float foward;

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
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 fpsMovementDir = new Vector3(transform.forward.x, 0, transform.forward.z);
            fpsMovementDir.Normalize();
            transform.position -= speed * transform.forward * Time.deltaTime;
        }

        transform.Rotate(Vector3.up, Input.GetAxis("Horizontal"), Space.World);
        transform.Rotate(transform.right, Input.GetAxis("Vertical"),Space.World);

        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(KnifeCloneTemplate, transform.position, transform.rotation);
        }
    }
    
    }

