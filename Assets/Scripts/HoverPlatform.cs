using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverPlatform : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float distance, antigraveForce;
    RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        antigraveForce = rb.mass;
        //rb.drag = rb.mass * 5f;

        if (Physics.Raycast(transform.position, Vector3.down, out hit, distance))
        {
            if (hit.collider != null)
            {
                rb.AddForce(transform.up * ((distance - hit.distance) / distance) * antigraveForce * 9.81f, ForceMode.Force);
            }
        }
    }

    void FixedUpdate()
    {
        
    }
}
