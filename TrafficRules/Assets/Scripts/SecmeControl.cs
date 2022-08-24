using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecmeControl : MonoBehaviour
{
    [SerializeField] Canvas Soru;
    public static DersTur dersTur;
    public GameObject Canlar;
    public GameObject[] CanYuva;

    void Start()
    {
        for (int i = 0; i < SoruCanvas.Can; i++)
        {
            Instantiate(Canlar, CanYuva[i].transform);

        }
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
