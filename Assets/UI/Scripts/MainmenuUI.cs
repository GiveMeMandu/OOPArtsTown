using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
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
