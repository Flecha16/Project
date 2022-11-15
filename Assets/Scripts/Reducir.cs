using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reducir : MonoBehaviour
{
    public float puntajeDeObjeto = -1.0f;
    public puntaje pt;

    private void Start() {
        pt = FindObjectOfType<puntaje>();
    }

    public void Update() {
        if(pt.puntos == 50){
            SceneManager.LoadScene(3);
        }
    }

    void  OnTriggerEnter (  Collider other   ){
        if (other.tag == "bala")//Si toca el tag "bala". 
        {
            pt.puntos += puntajeDeObjeto;
            Destroy(other.gameObject);//Destruye la bala.
        }
    }
}
