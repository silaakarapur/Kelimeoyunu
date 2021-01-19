using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seskontrol : MonoBehaviour
{
    AudioSource seskontrolll;

    void Start()
    {
        seskontrolll = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("sesDurum")==1)
        {
            seskontrolll.mute = true;
        }
        else
        {
            seskontrolll.mute = false;
        }
    }
}
