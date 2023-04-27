using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class NationController : MonoBehaviour
{
    public GameObject flower;
    public GameObject antiFlower;

    public float maxDelay;
    private GameObject nameTag;

    private string nationName;
    private List<float> rates = new List<float>();

    private float currentRate = 0f;
    private float previousRate = 0f;

    private int yearIndex = 0;
    private int currentYear = 0;

    void Start()
    {
        nameTag = gameObject.transform.GetChild(0).gameObject;
        nameTag.GetComponent<TextMeshPro>().text = nationName;
        try
        {
            currentRate = rates[yearIndex];
        }
        catch(Exception ex)
        {
            currentRate = 0;
        }
        currentYear = GenerativeSpawn.YEAR;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            if (nameTag.activeSelf) { nameTag.SetActive(false); } else { nameTag.SetActive(true); }
        }

        if (GenerativeSpawn.YEAR != currentYear)
        {
            previousRate = currentRate;
            try
            {
                currentRate = rates[yearIndex];
                yearIndex += GenerativeSpawn.YEAR - currentYear;
                currentRate = rates[yearIndex];
                currentYear = GenerativeSpawn.YEAR;
                var delta = currentRate - previousRate;
                if (delta > 0)
                {
                    float delay = UnityEngine.Random.Range(0, maxDelay);
                    StartCoroutine(SpawnFlower(delay, flower)); 
                }
                else
                {
                    if (currentYear > 1995)
                    {
                        float delay = UnityEngine.Random.Range(0, maxDelay);
                        StartCoroutine(SpawnFlower(delay, antiFlower));
                    }
                }
            }
            catch (Exception ex)
            {
                currentRate = 0;
                currentYear = GenerativeSpawn.YEAR;
            }

            if (currentYear > 2020)
            {
                float delay = UnityEngine.Random.Range(0, maxDelay);
                StartCoroutine(SpawnFlower(delay, antiFlower));
            }
        }
    }

    IEnumerator SpawnFlower(float delay, GameObject flowerType)
    {
        yield return new WaitForSeconds(delay);
        GameObject.Instantiate(flowerType, gameObject.transform.position, ((Quaternion.LookRotation(-Camera.main.transform.forward) * Quaternion.Euler(90, 0, 0))));
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
