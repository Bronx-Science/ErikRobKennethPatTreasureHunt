using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public Slider volumeSlider;
    float currentVolume;

    public Slider sensSlider;
    float currentSens;

    public void SetVolume(float volume)
    {
        currentVolume = volume;
    }

    public void SetSensitivity(float sens)
    {
        currentSens = sens;
    }

    void OnDisable()
    {
        PlayerPrefs.SetFloat("Volume", currentVolume);
        PlayerPrefs.SetFloat("Sensitivity", currentSens);
        PlayerPrefs.Save();
        Debug.Log(currentSens.ToString());
    }
}
