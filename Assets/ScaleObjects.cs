using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script to scale any object with the same value on all the axes
//max, min, and speed adjustable in inspector
public class ScaleObjects : MonoBehaviour
{
    
    public float maxScale;
    public float minScale;
    public float speed;
    private bool grow = false;

    // Update is called once per frame
    void Update()
    {
        if (grow)
        {
            gameObject.transform.localScale += new Vector3(speed *Time.deltaTime, speed * Time.deltaTime, speed * Time.deltaTime);

        }
        else
        {
            gameObject.transform.localScale -= new Vector3(speed * Time.deltaTime, speed * Time.deltaTime, speed * Time.deltaTime);

        }

        if (gameObject.transform.localScale.x >= maxScale)
        {
            grow = false;
        }
        if (gameObject.transform.localScale.x <= minScale)
        {
            grow = true;
        }
        
    }
}
