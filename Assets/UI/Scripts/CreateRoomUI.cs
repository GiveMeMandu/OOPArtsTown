using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Mirror;

public class CreateRoomUI : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField ipInputField;
    [SerializeField]
    private TMP_InputField maxPlayerInputField;

    public void CreateRoom()
    {
        //ip주소값 공백 검사
        if(ipInputField.text != "")
        {
            var manager = NetworkManager.singleton as OT_NetworkManager;
            manager.networkAddress = ipInputField.text;
            //maxPlayer 숫자 검사
            if(int.TryParse(maxPlayerInputField.text, out manager.maxConnections))
            {
                manager.StartHost();
            }
            else
            {
                //숫자만을 입력하라는 경고 문구 UI 표기
                ipInputField.GetComponent<Animator>().SetTrigger("on");
            } 
        }
        else
        {
            ipInputField.GetComponent<Animator>().SetTrigger("on");
        }
    }
}