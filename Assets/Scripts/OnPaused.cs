using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnPaused : MonoBehaviour
{
    [SerializeField] GameObject cameraMain;
    [SerializeField] GameObject cameraAddition;

    private bool _isPaused = false;


 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !_isPaused)
        {           
            _isPaused = true;
            
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && _isPaused)
        {
            _isPaused = false;
        }


        if (_isPaused)
        {
            cameraMain.SetActive(false);
            cameraAddition.SetActive(true);
            Cursor.visible = true;
            Screen.lockCursor = false;
        }
        else
        {
            cameraMain.SetActive(true);
            cameraAddition.SetActive(false);
            Cursor.visible = false;
            Screen.lockCursor = true;
        }
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void DontPaused()
    {
        cameraMain.SetActive(true);
        cameraAddition.SetActive(false);
    }
}
