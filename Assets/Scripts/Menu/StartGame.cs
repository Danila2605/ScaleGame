using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{

    void Awake()
    {
        PlayerPrefs.SetInt("Fullscreen", 1);
        Screen.fullScreen = PlayerPrefs.GetInt("Fullscreen") == 1;
        
    }




}
