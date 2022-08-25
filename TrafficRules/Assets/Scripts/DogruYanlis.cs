using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class DogruYanlis : MonoBehaviour
{
    //private static ArrayList array;
    //public static int Can = 5;
    //public static int rastgele;
    [SerializeField] Canvas canvas;
    [SerializeField] Canvas canvas2;
    [SerializeField] Canvas winCanvas;
    [SerializeField] Canvas loseCanvas;
    private SoruControl soru;
    public Image panel;
    private int rast;
    public GameObject Canlar;
    public GameObject[] CanYuva;
    private List<Sorular> soruList = SoruControl.SoruList;
    private List<Sorular> ilkList = SoruControl.IlkList;
    private List<Sorular> adabList = SoruControl.adabList;
    private List<Sorular> motorList = SoruControl.motorList;
    [SerializeField] TextMeshProUGUI soruText;
    [SerializeField] TextMeshProUGUI Cevap1;
    [SerializeField] TextMeshProUGUI Cevap2;
    [SerializeField] TextMeshProUGUI Cevap3;
    [SerializeField] TextMeshProUGUI Cevap4;
    void Start()
    {
        //rastgele = RastgeleOlustur();
        rast = SoruCanvas.rastgele;
        soruYaz();
        for (int i = 0; i < SoruCanvas.Can; i++)
        {
            Instantiate(Canlar, CanYuva[i].transform);
        }

    }

    void soruYaz()
    {
        soru = FindObjectOfType<SoruControl>();
        if (SecmeControl.dersTur == SecmeControl.DersTur.Trafic)
        {
            soruText.text = soruList[rast].Soru;
            Cevap1.text = soruList[rast].Cevap;
            Cevap2.text = soruList[rast].Cevap2;
            Cevap3.text = soruList[rast].Cevap3;
            Cevap4.text = soruList[rast].Cevap4;
        }
        else if (SecmeControl.dersTur == SecmeControl.DersTur.IlkYardim)
        {
            soruText.text = ilkList[rast].Soru;
            Cevap1.text = ilkList[rast].Cevap;
            Cevap2.text = ilkList[rast].Cevap2;
            Cevap3.text = ilkList[rast].Cevap3;
            Cevap4.text = ilkList[rast].Cevap4;
        }
        else if (SecmeControl.dersTur == SecmeControl.DersTur.Motor)
        {
            soruText.text = motorList[rast].Soru;
            Cevap1.text = motorList[rast].Cevap;
            Cevap2.text = motorList[rast].Cevap2;
            Cevap3.text = motorList[rast].Cevap3;
            Cevap4.text = motorList[rast].Cevap4;
        }
        else if (SecmeControl.dersTur == SecmeControl.DersTur.Adab)
        {
            soruText.text = adabList[rast].Soru;
            Cevap1.text = adabList[rast].Cevap;
            Cevap2.text = adabList[rast].Cevap2;
            Cevap3.text = adabList[rast].Cevap3;
            Cevap4.text = adabList[rast].Cevap4;
        }

    }

    void secmeKontrol()
    {
        if (SecmeControl.dersTur == SecmeControl.DersTur.Trafic)
        {
            if (SecmeControl.tra < 5)
            {
                SecmeControl.tra++;
            }
        }
        else if (SecmeControl.dersTur == SecmeControl.DersTur.IlkYardim)
        {
            if (SecmeControl.ilky < 5)
            {
                SecmeControl.ilky++;
            }
        }
        else if (SecmeControl.dersTur == SecmeControl.DersTur.Motor)
        {
            if (SecmeControl.mot < 5)
            {
                SecmeControl.mot++;
            }
        }
        else
        {
            if (SecmeControl.ada < 5)
            {
                SecmeControl.ada++;
            }
        }
    }

    int kontrol()
    {
        int kontrol;
        if (SecmeControl.dersTur == SecmeControl.DersTur.Trafic)
        {
            kontrol = soruList[rast].dogruIndex;
        }
        else if (SecmeControl.dersTur == SecmeControl.DersTur.IlkYardim)
        {
            kontrol = ilkList[rast].dogruIndex;
        }
        else if (SecmeControl.dersTur == SecmeControl.DersTur.Motor)
        {
            kontrol = motorList[rast].dogruIndex;
        }
        else
        {
            kontrol = adabList[rast].dogruIndex;
        }

        return kontrol;
    }
    
    public void nextQuestionWin()
    {

        if (SoruCanvas.soruSayisi == 5)
        {
            SoruCanvas.soruSayisi = 0;
            secmeKontrol();
            Destroy(gameObject);
            Instantiate(winCanvas, Vector3.zero, Quaternion.identity);
        }
        else
        {
            Destroy(gameObject);
            Instantiate(canvas, Vector3.zero, Quaternion.identity);
        }
    }
    public void nextQuestionLose()
    {
        if (SoruCanvas.Can == 0)
        {
            SoruCanvas.soruSayisi = 0;
            Destroy(gameObject);
            Instantiate(loseCanvas, Vector3.zero, Quaternion.identity);
        }
    }
}
