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

    public List<Material> flowerMaterials = new List<Material>();

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        Vector3 torque = new Vector3(0,0,Random.Range(-maxRotation, maxRotation));
        rb.AddTorque(torque, ForceMode.Impulse);
        var scaleValue = Random.Range(minScale, maxScale);
        transform.localScale = new Vector3(scaleValue, scaleValue, scaleValue);

        int material_index = (int) Random.Range(0, flowerMaterials.Count);

        Debug.Log(material_index);

        gameObject.GetComponent<Renderer>().material = flowerMaterials[material_index]; 
    }

    void Update()
    {
        
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
