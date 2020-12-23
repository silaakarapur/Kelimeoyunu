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
    int bulunan_kelime_sayisi=0;
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
        if (Input.GetButtonDown("Horizontal"))
        {
            tiklandi = true;
        }
        if (Input.GetButtonUp("Horizontal"))
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
                bulunan_kelime_sayisi++;
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
