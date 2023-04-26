using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Music : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        musicSource.volume = PlayerPrefs.GetFloat("Volume");
    }
}
