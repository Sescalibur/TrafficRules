using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class GameData
{
    public int[] test = new int[4];
    public int[] saat = new int[2];
    public int cans;
    public bool ses;

    public GameData()
    {
        test[0] = SecmeControl.tra;
        test[1] = SecmeControl.ilky;
        test[2] = SecmeControl.mot;
        test[3] = SecmeControl.ada;
        saat[0] = CanKontrol.saat[0];
        saat[1] = CanKontrol.saat[1];
        cans = SoruCanvas.Can;
        ses = SecmeControl.sessiz;
    }
}
