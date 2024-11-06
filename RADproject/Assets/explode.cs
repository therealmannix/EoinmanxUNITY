using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explode : MonoBehaviour
{
    Rigidbody rb;
    float ExplosionRadius = 10;
    float ExplosionStrenght = 1000;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(100 * transform.right,ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
  }

    private void OnCollisionEnter(Collision collision)
{
 Collider[] allvictimcolliders = Physics.OverlapSphere(transform.position,ExplosionRadius );
}
}

