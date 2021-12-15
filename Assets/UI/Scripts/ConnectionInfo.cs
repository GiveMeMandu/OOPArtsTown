using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using Mirror;

public class ConnectionInfo : MonoBehaviour
{
    [SerializeField]
    private TMP_Text ipText;
    [SerializeField]
    private TMP_Text rttText;
    [SerializeField]
    private TMP_Text numPlayerText;

    private int maxPlayers;

    private void Start()
    {
        var manager = NetworkManager.singleton as OT_NetworkManager;
        ipText.text += manager.networkAddress;
        maxPlayers = manager.maxConnections;
        numPlayerText.text = manager.numPlayers + " / " + maxPlayers;
        Debug.Log("Set Info");
    }

    private void FixedUpdate() {
        rttText.text = $"RTT: {Math.Round(NetworkTime.rtt * 1000)}ms";
    }
    
    public void UpdateNumPlayer()
    {
        var manager = NetworkManager.singleton as OT_NetworkManager;
        //var players = FindObjectsOfType<Player>();
        numPlayerText.text = string.Format("{0}/{1}", /*players.Length*/manager.numPlayers, maxPlayers);
    }
}
