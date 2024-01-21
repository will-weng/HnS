using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteamLobby : MonoBehaviour
{
    [SerializeField]
    private GameObject multiplayerUI = null;

    public void HostLobby()
    {
        multiplayerUI.SetActive(false);
        SteamMatchmaking.CreateLobby();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
