using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BgMusic : MonoBehaviour
{
    [SerializeField] Slider slider;

    private void Start()
    {
        slider.value = PlayerPrefs.GetFloat("Volume");
    }
    private void Update()
    {
        PlayerPrefs.SetFloat("Volume", slider.value);
        PlayerPrefs.Save();
    }
}
