using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    private void Start()
    {
        Cursor.visible = true;
        Screen.lockCursor = false;
    }
    /*public void AppearToContinue()
    {
        if (PlayerPrefs.HasKey("OnGame") == true)
        {
            buttonContinue.SetActive(true);
        }
        else
        {
            buttonContinue.SetActive(false);
        }
    }*/
    public void ToPlay()
    {
        SceneManager.LoadScene(2);
        PlayerPrefs.SetInt("OnGame", 1);
        
    }
    
    public void ToExit()
    {
        Application.Quit();
    }
}
