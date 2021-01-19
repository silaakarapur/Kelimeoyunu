using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    OyunOynama yonet;
    Image renk;
    RectTransform buyukluk;
    string harf;
    bool harf_verildi = false;
    int bulunanKelimeSayisi = 0;
    public bool yokol = false;
    float kuculmemiktari = 0.08f;

    void Start()
    {
        yonet = GameObject.Find("OyunOynama").GetComponent<OyunOynama>();
        renk = GetComponent<Image>();
        buyukluk = GetComponent<RectTransform>();
        harf = gameObject.name;

    }

    private void Update()
    {
        if (yonet.tiklandi==false)
        {
            harf_verildi = false;
            renk.color = Color.white;
        }

        if (yokol == true)
        {
            buyukluk.localScale -= new Vector3(kuculmemiktari, kuculmemiktari, kuculmemiktari);
            if (buyukluk.localScale.x<=0)
            {
                Destroy(gameObject);
            }
        }

    }
    public void Yesil_ol()
    {
        if (yonet.tiklandi==false)
        {
         renk.color = Color.green;
            if (harf_verildi == false)
            {
                yonet.Isaretli_buton_olustur(gameObject);
                harf_verildi = true;
            }
        }
    }
}
