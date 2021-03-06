using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameSettingsUI : SettingsUI
{
    public void QuitGame()
    {
        var manager = OT_NetworkManager.singleton;
        if(manager.mode == Mirror.NetworkManagerMode.Host)
        {
            manager.StopHost();
        }
        else if(manager.mode == Mirror.NetworkManagerMode.ClientOnly)
        {
            manager.StopClient();
        }
    }
}
