using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{
    // Explosion Variables
    [SerializeField] float force, radius;
    [SerializeField] Rigidbody rbody;
    [SerializeField] Collider[] colliders;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.name);
        colliders = Physics.OverlapSphere(transform.position, radius);
        
        foreach (Collider collider in colliders)
        {
            rbody = collider.transform.gameObject.GetComponentInParent<Rigidbody>();
            
            if (rbody != null)
            {
                rbody.AddExplosionForce(force, transform.position, radius);
            }
        }
    }
}
