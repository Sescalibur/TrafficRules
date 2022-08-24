using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoruControl : MonoBehaviour
{
    public Sorular[] soru;
    public static SoruControl instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

}
