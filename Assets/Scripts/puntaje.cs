using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class puntaje : MonoBehaviour
{
   public float puntos;

   private TextMeshProUGUI textMesh;

    private void Start() 
    {
        textMesh=GetComponent<TextMeshProUGUI>();
    
    }

    public void Update() {
        textMesh.text = puntos.ToString("0");
    }

}



