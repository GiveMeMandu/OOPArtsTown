using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainMenuUIManager : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField ipInputField;
    [SerializeField]
    private GameObject UI_MainMenu;
    [SerializeField]
    private GameObject UI_CreateRoom;
    [SerializeField]
    private GameObject UI_Settings;

    public void OnClickHostButton()
    {
        if(ipInputField.text != "")
        {
            OT_NetworkManager.singleton.networkAddress = ipInputField.text;
            UI_MainMenu.SetActive(false);
            UI_CreateRoom.SetActive(true);
        }
        else
        {
            ipInputField.GetComponent<Animator>().SetTrigger("on");
        }
    }
    
    public void OnClickClientButton()
    {
        if(ipInputField.text != "")
        {
            var manager = OT_NetworkManager.singleton;
            manager.networkAddress = ipInputField.text;
            manager.StartClient();
        }
        else
        {
            ipInputField.GetComponent<Animator>().SetTrigger("on");
        }
    }

    public void OnClickTutorialButton()
    {
        Application.OpenURL("https://github.com/GiveMeMandu/OOPArtsTown/wiki/Tutorial");
    }

    public void OnClickQuitButton()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
