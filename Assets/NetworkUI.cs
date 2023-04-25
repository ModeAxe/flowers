using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Netcode;

public class NetworkUI : MonoBehaviour
{
    [SerializeField] private Button host;
    [SerializeField] private Button client;

    public List<GameObject> offlineObjects = new List<GameObject>();

    private void Awake()
    {
        host.onClick.AddListener(() =>
        {
            NetworkManager.Singleton.StartHost();

        });

        client.onClick.AddListener(() =>
        {
            NetworkManager.Singleton.StartClient();

        });
    }

    private void prepareClient()
    {

    }

    private void prepareHost()
    {

    }
}
