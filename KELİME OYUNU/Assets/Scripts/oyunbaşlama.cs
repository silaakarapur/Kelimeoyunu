using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyunbaşlama : MonoBehaviour
{
    public static string girilen = "";
    public static bool ilktiklama = false;
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
    public void tiklandi()
    {
        girilen +=GetComponent<TextMesh>().text;
        Debug.Log(girilen);
    }
    public void OnMouseDown()
    {
        if (ilktiklama == false)
        {
            tiklandi();
            ilktiklama = true;
        }
     
    }
    public void OnMouseEnter()
    {
        if (ilktiklama == true)
        {
            tiklandi();
        }
        Debug.Log("üzerine gelindi");
    }
    public void OnMouseUp()
    {
        Debug.Log("bıraktı");
    }
}
