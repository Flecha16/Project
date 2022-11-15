using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Vidas : MonoBehaviour
{
    public float health;

    private TextMeshProUGUI textMesh;

    private void Start() 
    {
        textMesh=GetComponent<TextMeshProUGUI>();
    }

    public void Update() {
        textMesh.text = health.ToString(""); 
    }
}
