using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneController : MonoBehaviour
{
    public GameObject year;
    // Start is called before the first frame update
    void Start()
    {

        year.GetComponent<TextMeshPro>().text = GenerativeSpawn.YEAR.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        year.GetComponent<TextMeshPro>().text = GenerativeSpawn.YEAR.ToString();

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            if (year.activeSelf) { year.SetActive(false); } else { year.SetActive(true); }
        }


        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
    }
}
