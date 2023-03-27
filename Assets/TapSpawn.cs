using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject flower;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 mousePosition = Input.mousePosition;
            Debug.Log(mousePosition);
            Vector3 position = Camera.main.ScreenToWorldPoint(mousePosition);
            Spawn(position);
        }
    }

    void Spawn(Vector3 position)
    {
        Instantiate(flower, position, Quaternion.identity);
    }
}
