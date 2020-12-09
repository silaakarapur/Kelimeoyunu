using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayGame : MonoBehaviour
{
    //yonetici script dosyasına ulaşmak için
    yonetici yonet;
    //ımagebutonlarınrenginiseçildiğindedeğiştirmekiçintanımlandı
    Image renk;
    //butonların büyüklüğünü değiştirmek için
    RectTransform buyukluk;

    string harf;

    bool harf_verildi = false;

    public bool yok_ol;

    float kucultmemiktari = 0.08f;



    void Start()
    {
        yonet = GameObject.Find("yonetici").GetComponent<yonetici>();
        renk = GetComponent<Image>();
        buyukluk = GetComponent<RectTransform>();
        harf = gameObject.name;

    }

  
    private void Update()
    {
        if (yonet.tiklandi == false)
        {
            harf_verildi = false;
            renk.color = Color.white;
        }

        if (yok_ol == true)
        {
            buyukluk.localScale -= new Vector3(kucultmemiktari, kucultmemiktari, kucultmemiktari);

            if(buyukluk.localScale.x <= 0)
            {
                Destroy(gameObject);

            }
        }
        
    }


    public void gri_ol()
    {
        if(yonet.tiklandi == true)
        {
            renk.color = Color.gray;

            if (harf_verildi == false)
            {
                yonet.isaretli_buton_olustur(gameObject);
                harf_verildi = true;
            }

        }
    }
    

}
