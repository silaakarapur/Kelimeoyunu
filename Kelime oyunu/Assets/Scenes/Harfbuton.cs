using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Harfbuton : MonoBehaviour
{
    
    Image renk;
    RectTransform buyukluk;
    string harf;
    bool harf_verildi=false;
    public bool yok_ol= false;
    float kuculme_miktari=0.00f;
    void Start()
    {
        renk = GetComponent<Image>();
        buyukluk= GetComponent<RectTransform>();
        harf=gameObject.name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
