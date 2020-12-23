using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    OyunOynama yonet;
    Image renk;

    string harf;
    bool harf_verildi = false;

    public bool yokol = false;

    void Start()
    {
        yonet = GameObject.Find("OyunOynama").GetComponent<OyunOynama>();
        renk = GetComponent<Image>();
        

    }

    private void Update()
    {
        if (yonet.tiklandi == false)
        {
            harf_verildi = false;
            renk.color = Color.white;
        }


    }
    public void Yesil_ol()
    {
        if (yonet.tiklandi == true)
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
