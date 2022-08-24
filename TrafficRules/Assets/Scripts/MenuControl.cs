using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuControl : MonoBehaviour
{
    [SerializeField] Canvas Egitim;
    [SerializeField] Canvas Setting;
    public void menuPlay()
    {
        Destroy(gameObject);
        Instantiate(Egitim, Vector3.zero, Quaternion.identity);
    }

    public void settigPlay()
    {
        Destroy(gameObject);
        Instantiate(Setting, Vector3.zero, Quaternion.identity);
    }

    public void exit()
    {
        Application.Quit();
    }
}
