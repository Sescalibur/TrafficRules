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
    [SerializeField] Canvas canvas;
    [SerializeField] Canvas canvas2;
    [SerializeField] Canvas winCanvas;
    [SerializeField] Canvas loseCanvas;
    private SoruControl soru;
    public Image panel;

    public GameObject Canlar;
    public GameObject []CanYuva;
    //[SerializeField] GameObject panel2;
    [SerializeField] TextMeshProUGUI soruText;
    [SerializeField] TextMeshProUGUI Cevap1;
    [SerializeField] TextMeshProUGUI Cevap2;
    [SerializeField] TextMeshProUGUI Cevap3;
    [SerializeField] TextMeshProUGUI Cevap4;
    private static int soruSayisi;
    void Start()
    {
        soru=FindObjectOfType<SoruControl>();
        soruText.text = soru.soru[0].Soru;
        Cevap1.text = soru.soru[0].Cevap[0];
        Cevap2.text = soru.soru[0].Cevap2[0];
        Cevap3.text = soru.soru[0].Cevap3[0];
        Cevap4.text = soru.soru[0].Cevap4[0];
        for (int i = 0; i < Can; i++)
        {
            Instantiate(Canlar,CanYuva[i].transform);
            
        }
        
    }


    // Update is called once per frame
    public void cevapA()
    {
        if (soru.soru[0].dogruIndex == 1)
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
        if (soru.soru[0].dogruIndex == 2)
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
        if (soru.soru[0].dogruIndex == 3)
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
        if (soru.soru[0].dogruIndex == 4)
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

    public void nextQuestionWin()
    {
        
        if (soruSayisi == 5)
        {
            soruSayisi = 0;
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
