using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NationController : MonoBehaviour
{
    public GameObject flower;

    private string nationName;
    private List<float> rates = new List<float>();

    private float currentRate;
    private float previousRate;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(nationName);
        }
    }

    public void SetName(string name)
    {
        this.nationName = name;
    }

    public void SetRates(List<float> rates)
    {
        this.rates = rates;
    }
}
