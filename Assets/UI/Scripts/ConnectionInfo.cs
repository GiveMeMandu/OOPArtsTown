using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Mirror;

public class ConnectionInfo : MonoBehaviour
{
    [SerializeField]
    private TMP_Text ipText;
    [SerializeField]
    private TMP_Text numPlayerText;

    private int maxPlayers;

    private void Start()
    {
        var manager = OOPArtsTownNetworkManager.singleton;
        ipText.text += manager.networkAddress;
        maxPlayers = manager.maxConnections;
        numPlayerText.text = manager.numPlayers + " / " + maxPlayers;
        Debug.Log("Set Info");
    }
    
    public void UpdateNumPlayer()
    {
        var manager = OOPArtsTownNetworkManager.singleton;
        numPlayerText.text = manager.numPlayers + " / " + maxPlayers;
    }
}
