using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject flower;
    public GameObject backPlate;
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
            Vector3 position = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, backPlate.transform.position.z));
            Spawn(position);
        }

        Touch touch;
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                Vector2 mousePosition = touch.position;
                Vector3 position = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, backPlate.transform.position.z));
                Spawn(position);
            }
        }
    }

    void Spawn(Vector3 position)
    {
        Instantiate(flower, position, ((Quaternion.LookRotation(-Camera.main.transform.forward) * Quaternion.Euler(90,0,0))));
    }
}
