using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerativeSpawn : MonoBehaviour
{
    //timescale represents x number of seconds == one year
    public float timeScale = 20f;
    public GameObject backPlate;
    public GameObject NationPrefab;

    private List<GameObject> nations = new List<GameObject>();
    public float gridOffsetX = 0;
    public float gridOffsetY = 0;


    private int year = 1990;
    private float time;

    private List<Vector3> spawnPoints = new List<Vector3>();
    void Start()
    {
        time = 0;
        Vector3 uLeft = new Vector3(0, Screen.height, backPlate.transform.position.z);
        Vector3 lLeft = new Vector3(0, 0, backPlate.transform.position.z);
        Vector3 uRight = new Vector3(Screen.width, Screen.height, backPlate.transform.position.z);
        Vector3 lRight = new Vector3(Screen.width, 0, backPlate.transform.position.z);

        Vector3 gridUpperLeft = Camera.main.ScreenToWorldPoint(uLeft);
        Vector3 gridUpperRight = Camera.main.ScreenToWorldPoint(uRight);
        Vector3 gridLowerLeft = Camera.main.ScreenToWorldPoint(lLeft);
        Vector3 gridLowerRight = Camera.main.ScreenToWorldPoint(lRight);

        var x_delta = ((gridUpperLeft.x - gridOffsetX) - gridUpperRight.x) / 20;
        var y_delta = ((gridUpperLeft.y + gridOffsetY) - gridLowerLeft.y) / 10;

        Debug.Log(uLeft);
        Debug.Log(uRight);

        for (int i = 0; i < 20; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                float current_x = gridUpperLeft.x - (x_delta * i);
                float current_y = gridUpperLeft.y - (y_delta * j);
                Vector3 currentPoint = new Vector3(current_x, current_y, backPlate.transform.position.z);
                spawnPoints.Add(currentPoint);
            }

        }

        //Generate Nations (flower spawn points)
        foreach (Vector3 point in spawnPoints)
        {
            nations.Add(GameObject.Instantiate(NationPrefab, point, ((Quaternion.LookRotation(-Camera.main.transform.forward) * Quaternion.Euler(90, 0, 0)))));
        }

    }

    void Update()
    {
        if (time > timeScale)
        {
            time = 0;
            year++;
            Debug.Log(year);
        }
        time += Time.deltaTime;

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    for (int i = 70; i < 140; i++)
        //   {
        //        Destroy(nations[i]);
        //
        //    }
        //}

    }
}
