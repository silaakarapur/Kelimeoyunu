using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OyunOynama : MonoBehaviour
{
    
    public string[] sozluk;
    string kelime = null;
    public Text puan_txt;
    public bool tiklandi = false;
    int puan = 0;
    int bulunankelimesayisi=0;
    List<GameObject> isaretlibutonlar;
    void Start()
    {
        isaretlibutonlar = new List<GameObject>();
    }

    
    void Update()
    {
        if (Input.GetButtonDown("0"))
        {
            tiklandi = true;
        }
        if (Input.GetButtonUp("0"))
        {
            tiklandi = false;
            yaziolustur();
            puan_txt.text = puan.ToString();

        }
    }

    void yaziolustur()
    {
        foreach(string kelimeler in sozluk)
        {
            if (kelimeler == kelime)
            {
                puan += 100;
                bulunankelimesayisi++;
                foreach(GameObject buton in isaretlibutonlar)
                {
                   
                }
            }
        }
    }
}
