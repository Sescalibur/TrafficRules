using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SecmeControl : MonoBehaviour
{
    [SerializeField] Canvas Soru;
    public static DersTur dersTur;
    public GameObject Canlar;
    public GameObject[] CanYuva;
    [SerializeField] TextMeshProUGUI trafic;
    [SerializeField] TextMeshProUGUI motor;
    [SerializeField] TextMeshProUGUI ilk;
    [SerializeField] TextMeshProUGUI adab;
    public static int tra;
    public static int mot;
    public static int ilky;
    public static int ada;

    void Start()
    {
        for (int i = 0; i < SoruCanvas.Can; i++)
        {
            Instantiate(Canlar, CanYuva[i].transform);

        }

        trafic.text = tra + "/5";
        motor.text = mot + "/5";
        ilk.text = ilky + "/5";
        adab.text = ada + "/3";
    }
    public enum DersTur
    {
        Trafic,
        Adab,
        Motor,
        IlkYardim
    }
    
    public void Trafics()
    {
        dersTur = DersTur.Trafic;
        Destroy(gameObject);
        Instantiate(Soru, Vector3.zero, Quaternion.identity);
    }
    public void Motor()
    {
        dersTur = DersTur.Motor;
        Destroy(gameObject);
        Instantiate(Soru, Vector3.zero, Quaternion.identity);
    }
    public void Adab()
    {
        dersTur = DersTur.Adab;
        Destroy(gameObject);
        Instantiate(Soru, Vector3.zero, Quaternion.identity);
    }
    public void IlkYardim()
    {
        dersTur = DersTur.IlkYardim;
        Destroy(gameObject);
        Instantiate(Soru, Vector3.zero, Quaternion.identity);
    }
}
