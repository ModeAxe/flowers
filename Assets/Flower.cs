using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour
{
    private Rigidbody rb;

    public float maxRotation = 10;
    public float minScale;
    public float maxScale;

    public float lifetime;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        Vector3 torque = new Vector3(0,0,Random.Range(-maxRotation, maxRotation));
        rb.AddTorque(torque, ForceMode.Impulse);
        transform.localScale = new Vector3(Random.Range(minScale, maxScale), Random.Range(minScale, maxScale), Random.Range(minScale, maxScale));
        
    }

    void Update()
    {
        
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
