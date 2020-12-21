using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    OyunOynama yonet;
    Image renk;

    string harf;
    bool harfverildi = false;

    public bool yokol = false;

    void Start()
    {
        yonet = GameObject.Find("OyunOynama").GetComponent<OyunOynama>();
        renk = GetComponent<Image>();
        harf = GameObject.name;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
