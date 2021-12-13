using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnterRoomUI : MonoBehaviour
{
    [SerializeField]
    public TMP_InputField ipInputField;
    [SerializeField]
    public TMP_InputField portInputField;

    public void EnterRoom()
    {
        if(ipInputField.text != "" || portInputField.text != "")
        {
            var manager = OOPArtsTownNetworkManager.singleton;
            manager.StartClient();
        }
        else
        {
            var manager = OOPArtsTownNetworkManager.singleton;
            manager.StartClient();
            //nicknameInputField.GetComponent<Animator>().SetTrigger("on");
        }
    }
}
