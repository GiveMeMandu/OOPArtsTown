using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnterRoomUI : MonoBehaviour
{
    [SerializeField]
    public TMP_InputField ipInputField;

    public void EnterRoom()
    {
        if(ipInputField.text != "")
        {
            var manager = OOPArtsTownNetworkManager.singleton;
            manager.StartClient();
        }
        else
        {
            ipInputField.GetComponent<Animator>().SetTrigger("on");
        }
    }
}
