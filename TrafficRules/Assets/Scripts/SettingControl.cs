using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingControl : MonoBehaviour
{
    public Canvas canvas;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void menuCanvas()
    {
        Destroy(gameObject);
        Instantiate(canvas, Vector3.zero, Quaternion.identity);
    }

    public void setVolume(float value)
    {
        AudioListener.volume = value;
    }
}
