using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class SoruCanvas : MonoBehaviour
{
    
    public static int Can = 5;
    public static int rastgele;
    [SerializeField] Canvas canvas;
    [SerializeField] Canvas canvas2;
    [SerializeField] Canvas winCanvas;
    [SerializeField] Canvas loseCanvas;
    private SoruControl soru;
    public Image panel;
    public GameObject Canlar;
    public GameObject []CanYuva;
    [SerializeField] TextMeshProUGUI soruText;
    [SerializeField] TextMeshProUGUI Cevap1;
    [SerializeField] TextMeshProUGUI Cevap2;
    [SerializeField] TextMeshProUGUI Cevap3;
    [SerializeField] TextMeshProUGUI Cevap4;
    public static int soruSayisi;
    private List<Sorular> soruList = SoruControl.SoruList;
    private List<Sorular> ilkList = SoruControl.IlkList;
    private List<Sorular> adabList = SoruControl.adabList;
    private List<Sorular> motorList = SoruControl.motorList;
    private List<int> array = new List<int>();
    void Start()
    {
        rastgele = RastgeleOlustur();
        array.Add(rastgele);
        soruYaz();
        for (int i = 0; i < Can; i++)
        {
            Instantiate(Canlar,CanYuva[i].transform);
        }
    }

    void soruYaz()
    {
        soru = FindObjectOfType<SoruControl>();
        if (SecmeControl.dersTur == SecmeControl.DersTur.Trafic)
        {
            soruText.text = soruList[rastgele].Soru;
            Cevap1.text = soruList[rastgele].Cevap;
            Cevap2.text = soruList[rastgele].Cevap2;
            Cevap3.text = soruList[rastgele].Cevap3;
            Cevap4.text = soruList[rastgele].Cevap4;
        }
        else if (SecmeControl.dersTur == SecmeControl.DersTur.IlkYardim)
        {
            soruText.text = ilkList[rastgele].Soru;
            Cevap1.text = ilkList[rastgele].Cevap;
            Cevap2.text = ilkList[rastgele].Cevap2;
            Cevap3.text = ilkList[rastgele].Cevap3;
            Cevap4.text = ilkList[rastgele].Cevap4;
        }
        else if (SecmeControl.dersTur == SecmeControl.DersTur.Motor)
        {
            soruText.text = motorList[rastgele].Soru;
            Cevap1.text = motorList[rastgele].Cevap;
            Cevap2.text = motorList[rastgele].Cevap2;
            Cevap3.text = motorList[rastgele].Cevap3;
            Cevap4.text = motorList[rastgele].Cevap4;
        }
        else if (SecmeControl.dersTur == SecmeControl.DersTur.Adab)
        {
            soruText.text = adabList[rastgele].Soru;
            Cevap1.text = adabList[rastgele].Cevap;
            Cevap2.text = adabList[rastgele].Cevap2;
            Cevap3.text = adabList[rastgele].Cevap3;
            Cevap4.text = adabList[rastgele].Cevap4;
        }

    }


    // Update is called once per frame
    public void cevapA()
    {
        int kontrol = this.kontrol();
        
        if (kontrol == 1)
        {
            panel.color = Color.green;
            soruSayisi++;
            Destroy(gameObject);
            Instantiate(canvas, Vector3.zero, Quaternion.identity);
        }
        else
        {
            if (Can > 0)
            {
                Can--;
            }

            if (Can > 0)
            {
                panel.color = Color.red;
                soruSayisi++;
                Destroy(gameObject);
                Instantiate(canvas2, Vector3.zero, Quaternion.identity);
            }
            nextQuestionLose();

        }
    }

    public void cevapB()
    {
        int kontrol = this.kontrol();
        if (kontrol == 2)
        {
            panel.color = Color.green;
            soruSayisi++;
            Destroy(gameObject);
            Instantiate(canvas, Vector3.zero, Quaternion.identity);
            
        }
        else
        {
            if (Can > 0)
            {
                Can--;
            }

            if (Can > 0)
            {
                panel.color = Color.red;
                soruSayisi++;
                Destroy(gameObject);
                Instantiate(canvas2, Vector3.zero, Quaternion.identity);
            }
            nextQuestionLose();

        }
    }

    public void cevapC()
    {
        int kontrol = this.kontrol();
        if (kontrol == 3)
        {
            panel.color = Color.green;
            soruSayisi++;
            Destroy(gameObject);
            Instantiate(canvas, Vector3.zero, Quaternion.identity);

        }
        else
        {
            if (Can > 0)
            {
                Can--;
            }

            if (Can > 0)
            {
                panel.color = Color.red;
                soruSayisi++;
                Destroy(gameObject);
                Instantiate(canvas2, Vector3.zero, Quaternion.identity);
            }
            nextQuestionLose();

        }
    }

    public void cevapD()
    {
        int kontrol = this.kontrol();
        if (kontrol == 4)
        {
            panel.color = Color.green;
            soruSayisi++;
            Destroy(gameObject);
            Instantiate(canvas, Vector3.zero, Quaternion.identity);

        }
        else
        {
            if (Can > 0)
            {
                Can--;
            }

            if (Can > 0)
            {
                panel.color = Color.red;
                soruSayisi++;
                Destroy(gameObject);
                Instantiate(canvas2, Vector3.zero, Quaternion.identity);
            }
            nextQuestionLose();
            
        }
    }

    int kontrol()
    {
        int kontrol;
        if (SecmeControl.dersTur == SecmeControl.DersTur.Trafic)
        {
            kontrol = soruList[rastgele].dogruIndex;
        }
        else if (SecmeControl.dersTur == SecmeControl.DersTur.IlkYardim)
        {
            kontrol = ilkList[rastgele].dogruIndex;
        }
        else if (SecmeControl.dersTur == SecmeControl.DersTur.Motor)
        {
            kontrol = motorList[rastgele].dogruIndex;
        }
        else
        {
            kontrol = adabList[rastgele].dogruIndex;
        }

        return kontrol;
    }
    void ArraySil()
    {
        if (SecmeControl.dersTur == SecmeControl.DersTur.Trafic)
        {
            for (int j = 0; j < array.Count; j++)
            {
                soruList.RemoveAt(array[j]);
            }
            array.Clear();
        }
    }
    int RastgeleOlustur()
    {
        int kontrol;
        if (SecmeControl.dersTur == SecmeControl.DersTur.Trafic)
        {
            kontrol = Random.Range(0,15);
        }
        else if (SecmeControl.dersTur == SecmeControl.DersTur.IlkYardim)
        {
            kontrol = Random.Range(0, 15);
        }
        else if (SecmeControl.dersTur == SecmeControl.DersTur.Motor)
        {
            kontrol = Random.Range(0, 15);
        }
        else
        {
            kontrol = Random.Range(0, 9);
        }

        return kontrol;
    }

    public void nextQuestionWin()
    {
        
        if (soruSayisi == 5)
        {
            soruSayisi = 0;
            //ArraySil();
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
        if (Can == 0)
        {
            soruSayisi=0;
            Destroy(gameObject);
            Instantiate(loseCanvas, Vector3.zero, Quaternion.identity);
        }
    }
}
