using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NewBehaviourScript : MonoBehaviour
{
     public void oyun()
    {
     //oyunu başlatan kısım
   Application.LoadLevel("level");
   
    }

    public void Quit(){
        Application.Quit();
        Debug.Log("Quit");
    }
    public void LevelSelect(int Levelnumber){
        SceneManager.LoadScene("level"+ levelnumber);
    }
}
