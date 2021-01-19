using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundonoff : MonoBehaviour
{
    public GameObject sesaçik, seskapali;

    void Start()
    {
        PlayerPrefs.SetInt("sesDurum", 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetFloat("sesDurum") == 1)
        {
            sesaçik.SetActive(false);
            seskapali.SetActive(true);
            PlayerPrefs.SetInt("sesDurum", 0);
        }
        else
        {
            sesaçik.SetActive(true);
            seskapali.SetActive(false);
            PlayerPrefs.SetInt("sesDurum", 1);
        }
    }
    public void ses_durum(string durum)
    {
        if(durum == "açık")
        {
            sesaçik.SetActive(false);
            seskapali.SetActive(true);
            PlayerPrefs.SetInt("sesDurum", 0);
        }
        else
        {
            sesaçik.SetActive(true);
            seskapali.SetActive(false);
            PlayerPrefs.SetInt("sesDurum",1);
        }
    }
}
