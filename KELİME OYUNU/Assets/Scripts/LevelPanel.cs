using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelPanel : MonoBehaviour
{
    public void levelSelect(int levelNumber)
    {
        SceneManager.LoadScene("level" + levelNumber);
    }

    //buradan sonrasını nasıl oynanır kısmı için ekledim...

    [Header("Nasl oynanir panel")]
    public GameObject Nasiloynanirpanel;
    [Header("level panel")]
    public GameObject levelpanel;

    public void Nasiloynaniraçma()
    {
        levelpanel.SetActive(false);
        Nasiloynanirpanel.SetActive(true);
    }
    public void Oyunudönüsgeributton()
    {
        levelpanel.SetActive(true);
        Nasiloynanirpanel.SetActive(false);
    }
}
