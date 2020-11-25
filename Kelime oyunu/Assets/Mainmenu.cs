using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class Mainmenü : MonoBehaviour
{
    [Header("baslangicsayfalari")]
    public GameObject oyunekrani;
    public GameObject seviyeekrani;
    public GameObject Siralamaekrani;
    public GameObject Ayarlarekrani;
    
    string level;
    

    
    public void oyun()
    {
        //oyunu başlatan kısım
      Application.LoadLevel("level");
      {
    
      }
    }
    public void Seviye()
    {
        oyunekrani.SetActive(false);
        seviyeekrani.SetActive(true);
    }
    public void Seviye2menu()
    {
        oyunekrani.SetActive(true);
        seviyeekrani.SetActive(false);
    }
    public void Siralama()
    {
        oyunekrani.SetActive(false);
        Siralamaekrani.SetActive(true);
    }
    public void Siralama2menu()
    {
        oyunekrani.SetActive(true);
        Siralamaekrani.SetActive(false);
    }
    public void Ayarlar()
    {
        oyunekrani.SetActive(false);
        Ayarlarekrani.SetActive(true);
    }
    public void Ayarlar2menü()
    {
        oyunekrani.SetActive(true);
        Ayarlarekrani.SetActive(false);
    }
    public void cikis()
    {
        Application.Quit();

    }

    //deneme 123 abc//
}