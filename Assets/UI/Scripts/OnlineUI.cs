using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OnlineUI : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField nicknameInputField;
    [SerializeField]
    private GameObject createRoomUI;

    public void OnClickCreateRoomButton()
    {
        if(nicknameInputField.text != "")
        {
            PlayerSettings.nickname = nicknameInputField.text;
            Debug.Log(nicknameInputField.text);
            createRoomUI.SetActive(true);
            gameObject.SetActive(false);
        }
        else
        {
            nicknameInputField.GetComponent<Animator>().SetTrigger("on");
        }
    }
}
