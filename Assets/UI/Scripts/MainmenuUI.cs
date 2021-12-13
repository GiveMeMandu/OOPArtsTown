using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainmenuUI : MonoBehaviour
{
    public void OnClickOnlineButton()
    {
        Debug.Log("Click Online");
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
