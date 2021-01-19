using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OyunOynama : MonoBehaviour
{
    
    public string[] sozluk;
    string kelime = null;
    public Text puan_txt;
    int bulunanKelimeSayisi = 0;
    public bool tiklandi = false;
    int puan = 0;
    List<GameObject> Isaretlibutonlar;
    void Start()
    {
        Isaretlibutonlar = new List<GameObject>();
    }

    public void Isaretli_buton_olustur(GameObject buton)
    {
        Isaretlibutonlar.Add(buton);
        kelime = null;
        foreach(GameObject butonlar in Isaretlibutonlar)
        {
            kelime = kelime + butonlar.name;
            puan_txt.text = kelime;        }
     }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            tiklandi = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            tiklandi = false;
            Yaziolustur();
            puan_txt.text = puan.ToString();

        }
    }

    void Yaziolustur()
    {
        foreach(string kelimeler in sozluk)
        {
            if (kelimeler == kelime)
            {
                puan += 100;
                bulunanKelimeSayisi++;
                foreach(GameObject buton in Isaretlibutonlar)
                {
                    buton.GetComponent<Button>().yokol = true;
                }
            }
        }
        Isaretlibutonlar.Clear();
        kelime = null;
       
    }
}
