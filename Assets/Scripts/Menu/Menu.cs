using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void ToPlay()
    {
        SceneManager.LoadScene(0);
    }

    public void ToContinue()
    {
        //TODO
    }
    public void ToSettings()
    {
        //TODO
    }
    public void ToExit()
    {
        Application.Quit();
    }
}
