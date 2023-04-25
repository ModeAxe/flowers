using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyPostion : MonoBehaviour
{
    public GameObject parent;
    // Start is called before the first frame update
    void Start()
    {
        transform.SetParent(parent.transform);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
