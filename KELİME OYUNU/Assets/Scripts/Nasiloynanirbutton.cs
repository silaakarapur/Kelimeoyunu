using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Nasiloynanirbutton : MonoBehaviour
{
    [Header("Nasl oynanir panel")]
    public GameObject Nasiloynanirpanel;
    [Header("level panel")]
    public GameObject levelpanel;
    public void nasiloynaniracma()
    {
        levelpanel.SetActive(false);
        Nasiloynanirpanel.SetActive(true);
    }
    public void oyunaDon()
    {
        levelpanel.SetActive(true);
        Nasiloynanirpanel.SetActive(false);
    }
    
}
