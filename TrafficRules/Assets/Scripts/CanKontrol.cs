using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanKontrol : MonoBehaviour
{
    private bool kontrol;
    public static int[] saat = new int[2];
    private float saat4;
    
    void Start()
    {
        SettingControl.loaddene();
        load();
    }

    // Update is called once per frame
    void Update()
    {
        if (SoruCanvas.Can < 5)
        {
            saat[0] = DateTime.Now.Hour;
            saat[1] = DateTime.Now.Minute;
        }
    }


    void save()
    {
        SaveSystem.Save();
    }
    void load()
    {
        GameData data = SaveSystem.Load();
        SecmeControl.tra = data.test[0];
        SecmeControl.ilky = data.test[1];
        SecmeControl.mot = data.test[2];
        SecmeControl.ada = data.test[3];
        SoruCanvas.Can = data.cans;
        SecmeControl.sessiz = data.ses;
        if (SecmeControl.sessiz)
        {
            AudioListener.volume = 0;
        }
        int saat = CanKontrol.saat[0] - data.saat[0];
        for (int i = 0; i < saat / 4; i++)
        {
            if (SoruCanvas.Can < 5)
            {
                if (saat > 4)
                {
                    SoruCanvas.Can++;
                    saat -= 4;
                    Debug.Log(saat);
                }
            }
        }
    }
}
