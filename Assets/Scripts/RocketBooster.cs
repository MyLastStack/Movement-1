using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketBooster : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float boosterForce;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponentInParent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        rb.AddForceAtPosition(transform.up * boosterForce * Time.deltaTime, transform.position);
    }
}
