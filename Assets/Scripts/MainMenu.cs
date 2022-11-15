using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Update() {
        if(Input.GetKeyDown(KeyCode.I)){
            Time.timeScale = 1f;
            EscenaJuego();
        } else if (Input.GetKeyDown(KeyCode.P)){
            Scores();
        } else if (Input.GetKeyDown(KeyCode.S)){
            Salir();
        }
    }

    public void EscenaJuego(){
        SceneManager.LoadScene("Juego");
    }

    public void Scores(){
        SceneManager.LoadScene("Scores");
    }

    public void Salir(){
        Debug.Log("Cerrando juego.");
        Application.Quit();
    }
}
