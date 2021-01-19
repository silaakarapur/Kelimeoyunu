using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playing : MonoBehaviour
{
    public string[] sozluk;
    string kelime = null;
    public Text puantxt;
    Image renk;
    string harf;
    public bool tiklandi = false;
    public bool yokol = false;
    bool harfVerildi = false;
    int bulunanKelimeSayisi = 0;
    int puan = 0;
    List<GameObject> Isaretlibutonlar;
    void Start()
    {
        Isaretlibutonlar = new List<GameObject>();
        renk = GetComponent<Image>();
        harf = gameObject.name;
    }


    private void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            tiklandi = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            tiklandi = false;
            Yaziolustur();
            puantxt.text = puan.ToString();

        }
    }
    public void Yesil_ol()
    {
        if (Input.GetMouseButtonDown(0))
        {
            tiklandi = true;
            renk.color = Color.green;
        }
        if (Input.GetMouseButtonUp(0))
        {
            renk.color = Color.yellow;
        }
    }
    private void Update()
    {
        if (tiklandi == false)
        {
            harfVerildi = false;
            renk.color = Color.green;
        }
        if (yokol == true)
        {
            Destroy(gameObject);
        }
    }
    void Yaziolustur()
    {
        foreach (string kelimeler in sozluk)
        {
            if (kelimeler == kelime)
            {
                puan += 100;
                bulunanKelimeSayisi++;
                foreach (GameObject buton in Isaretlibutonlar)
                {
                    buton.GetComponent<Button>().yokol = true;
                }
            }
        }
        Isaretlibutonlar.Clear();
        kelime = null;

    }
}

