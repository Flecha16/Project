using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Balas : MonoBehaviour
{
    public float balas;

    private TextMeshProUGUI textMesh;

    private void Start() 
    {
        textMesh=GetComponent<TextMeshProUGUI>();
        balas = 10;
    }

    public void Update() {
        textMesh.text = balas.ToString(""); 
    }
}
