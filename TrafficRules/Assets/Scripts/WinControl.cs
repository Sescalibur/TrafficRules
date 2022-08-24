using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinControl : MonoBehaviour
{
    public GameObject Canlar;
    public GameObject[] CanYuva;
    public Canvas NextCanvas;
    public Canvas MenuCanvas;
    public Canvas SettingCanvas;
    void Start()
    {
        for (int i = 0; i < SoruCanvas.Can; i++)
        {
            Instantiate(Canlar, CanYuva[i].transform);

        }
    }

    public void playAgain()
    {
        Destroy(gameObject);
        Instantiate(NextCanvas, Vector3.zero, Quaternion.identity);
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
}
