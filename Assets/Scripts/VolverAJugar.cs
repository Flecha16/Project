using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VolverAJugar : MonoBehaviour
{
    void Update() {
        if(Input.GetKeyDown(KeyCode.V)){
            EscenaJuego();
        }
    }

    public void EscenaJuego(){
        SceneManager.LoadScene("MainMenu");
    }

}
