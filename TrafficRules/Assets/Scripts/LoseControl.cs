using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseControl : MonoBehaviour
{
    public GameObject Canlar;
    public GameObject[] CanYuva;
    public Canvas MenuCanvas;
    public Canvas SettingCanvas;
    void Start()
    {
        for (int i = 0; i < SoruCanvas.Can; i++)
        {
            Instantiate(Canlar, CanYuva[i].transform);

        }
    }
    public void Menu()
    {
        Destroy(gameObject);
        Instantiate(MenuCanvas, Vector3.zero, Quaternion.identity);
    }

    public void Setting()
    {
        Destroy(gameObject);
        Instantiate(SettingCanvas, Vector3.zero, Quaternion.identity);
    }
    public void mute()
    {
        if (SecmeControl.sessiz)
        {
            AudioListener.volume = PlayerPrefs.GetFloat("audioVolume");
            SecmeControl.sessiz = false;

        }
        else
        {
            AudioListener.volume = 0;
            SecmeControl.sessiz = true;
        }
        SaveSystem.Save();
    }
}
