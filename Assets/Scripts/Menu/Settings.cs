using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    [SerializeField] TMP_Dropdown resolutions;
    [SerializeField] Toggle fullscreen;

    [SerializeField] TMP_Dropdown quality;
    [SerializeField] Slider volume;

    [SerializeField] TMP_Text text;

    private bool _fullscreen = true;


    private void Awake()
    {
        var listAvailableStrings = resolutions.options.Select(option => option.text).ToList();
        resolutions.value = PlayerPrefs.GetInt("Resolution"); 
    }
    public void Fullscreen()
    {
        _fullscreen = !_fullscreen;
        Screen.fullScreen = _fullscreen;
        text.text = "full";

        if (fullscreen.isOn)
        {
            fullscreen.isOn = false;
            text.text = "false";
        }
        else
        {
            fullscreen.isOn = true;
            text.text = "true";
        }
        

        PlayerPrefs.SetInt("Fullscreen", _fullscreen ? 1 : 0);
    }

    public void SetResolutions()
    {
        bool isFullscreen = PlayerPrefs.GetInt("Fullscreen") == 1;

        PlayerPrefs.SetInt("Resolution", resolutions.value);

        int selectedIndex = PlayerPrefs.GetInt("Resolution");

        if (selectedIndex == 0)
        {
            Screen.SetResolution(1920, 1080, isFullscreen);
        }
        else if(selectedIndex == 1)
        {
            Screen.SetResolution(1600, 900, isFullscreen);
        }
        else if (selectedIndex == 2)
        {
            Screen.SetResolution(1280, 720, isFullscreen);
        }
        else if (selectedIndex == 3)
        {
            Screen.SetResolution(1024, 768, isFullscreen);
        }   
    }
}
