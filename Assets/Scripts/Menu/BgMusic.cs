using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BgMusic : MonoBehaviour
{
    [SerializeField] Slider volume;
    private AudioSource audioSrc;
    private float musicVolume;

    private void Awake()
    {
        audioSrc = GetComponent<AudioSource>();
        audioSrc.volume = PlayerPrefs.GetFloat("Volume");
        volume.value = PlayerPrefs.GetFloat("Volume");
    }

    public void SetVolume(float vol)
    {
        musicVolume = vol;
        PlayerPrefs.SetFloat("Volume", musicVolume);
        PlayerPrefs.Save();

        /*volume.value = musicVolume;*/
    }

    private void Update()
    {
        volume.value = PlayerPrefs.GetFloat("Volume");
    }
    
}
