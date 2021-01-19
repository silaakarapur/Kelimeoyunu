using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class AnaMenuManager : MonoBehaviour
{
    [Header("LEVEL MENÜ HEADER")]
    public GameObject LevelPanel;

    [Header("ANA MENÜ HEADER")]
    public  GameObject Anamenupaneli;

    [Header("SETTİNG PANEL HEADER")]
    public GameObject SettingPanel;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    public void Oyunubaslat()
    {
        SceneManager.LoadScene("level1");
    }
    public void Levelpaneldenanamenuye(){
        LevelPanel.SetActive(false);
        Anamenupaneli.SetActive(true);
    }
    public void Settingdenanamenuye(){
        SettingPanel.SetActive(false);
        Anamenupaneli.SetActive(true);
    }
    public void LevelPanelegir(){
        Anamenupaneli.SetActive(false);
        LevelPanel.SetActive(true);
    }
    public void SettingPanelegir(){
        Anamenupaneli.SetActive(false);
        SettingPanel.SetActive(true);
    }
    
    public void Çıkış(){
        Application.Quit();
    }
}
