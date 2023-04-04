using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour
{
    private Rigidbody rb;

    public float maxRotation = 10;

    public float lifetime;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        Vector3 torque = new Vector3(0,0,Random.Range(-maxRotation, maxRotation));
        rb.AddTorque(torque, ForceMode.Impulse);        
        
    }

    void Update()
    {
        
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
