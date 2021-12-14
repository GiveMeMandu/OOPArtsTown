using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Mirror;

public class CreateRoomUI : MonoBehaviour
{
    [SerializeField]
    public TMP_InputField ipInputField;
    [SerializeField]
    private TMP_InputField maxPlayerInputField;

    private CreateGameRoomData roomData;

    public void CreateRoom()
    {
        if(ipInputField.text != "")
        {
            var manager = OOPArtsTownNetworkManager.singleton;
            manager.StartHost();
        }
        else
        {
            ipInputField.GetComponent<Animator>().SetTrigger("on");
        }
    }
}

public class CreateGameRoomData
{
    public int maxPlayerCount;
}