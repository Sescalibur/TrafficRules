using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingControl : MonoBehaviour
{
    public Canvas canvas;
    public Slider slider;

    void Start()
    {
        loadSetting();
        
    }
    public void menuCanvas()
    {
        Destroy(gameObject);
        Instantiate(canvas, Vector3.zero, Quaternion.identity);
    }

    public void setVolume(float value)
    {
        AudioListener.volume = value;
        saveSetting();
    }

    private void saveSetting()
    {
        PlayerPrefs.SetFloat("audioVolume",AudioListener.volume);
    }

    private void loadSetting()
    {
        if (PlayerPrefs.HasKey("audioVolume"))
        {
            AudioListener.volume = PlayerPrefs.GetFloat("audioVolume");
            slider.value = PlayerPrefs.GetFloat("audioVolume");
        }
        else
        {
            PlayerPrefs.SetFloat("audioVolume", 0.5f);
            AudioListener.volume = PlayerPrefs.GetFloat("audioVolume");
            slider.value = PlayerPrefs.GetFloat("audioVolume");
        }
    }

    public static void loaddene()
    {
        if (PlayerPrefs.HasKey("audioVolume"))
        {
            AudioListener.volume = PlayerPrefs.GetFloat("audioVolume");
            //slider.value = PlayerPrefs.GetFloat("audioVolume");
        }
        else
        {
            PlayerPrefs.SetFloat("audioVolume", 0.5f);
            AudioListener.volume = PlayerPrefs.GetFloat("audioVolume");
            //slider.value = PlayerPrefs.GetFloat("audioVolume");
        }
    }
}
