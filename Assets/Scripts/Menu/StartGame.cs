using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public Settings settings;
    void Awake()
    {
        Screen.fullScreen = PlayerPrefs.GetInt("Resolution") == 1;
        print("Awake");
    }

    private void Start()
    {
        if (PlayerPrefs.GetInt("Fullscreen") == 1)
        {
            settings.Fullscreen();
        }
    }


}
