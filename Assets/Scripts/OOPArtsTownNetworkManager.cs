using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class OOPArtsTownNetworkManager : NetworkManager
{
    public override void OnServerConnect(NetworkConnection conn)
    {
        //ConnectionInfo.UpdateNumPlayer();
    }

    public override void OnServerDisconnect(NetworkConnection conn)
    {
        //ConnectionInfo.UpdateNumPlayer();
    }
}
