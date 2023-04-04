using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerativeSpawn : MonoBehaviour
{
    //timescale represents x number of seconds == one year
    public float timeScale = 20f;
    private int year = 1990;
    private float time;
    void Start()
    {
        time = 0;

        
    }

    // Update is called once per frame
    void Update()
    {
        if (time > timeScale)
        {
            time = 0;
            year++;
            Debug.Log(year);
        }
        time += Time.deltaTime;

        
    }
}
