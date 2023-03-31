using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject flower;
    public float offset = 10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Input.mousePosition;
            Debug.Log(mousePosition);
            Vector3 position = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, offset));
            Spawn(position);
        }
    }

    void Spawn(Vector3 position)
    {
        Instantiate(flower, position, ((Quaternion.LookRotation(-Camera.main.transform.forward) * Quaternion.Euler(90,0,0))));
    }
}
