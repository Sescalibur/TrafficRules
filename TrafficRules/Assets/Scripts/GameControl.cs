using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    [SerializeField] private Canvas [] canvas;
    private Canvas canva;
    
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("Music");
        canva = Instantiate(canvas[0],Vector3.zero, Quaternion.identity);
    }

}
