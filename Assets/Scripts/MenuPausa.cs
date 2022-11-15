using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    //[SerializeField] private GameObject botonPausa;
    [SerializeField] private GameObject menuPausa;

    void Update() {
        if(Input.GetKeyDown(KeyCode.P)){
            Pausa();
        } else if (Input.GetKeyDown(KeyCode.R)){
            Reanudar();
        } else if (Input.GetKeyDown(KeyCode.E)){
            Reiniciar();
        } else if (Input.GetKeyDown(KeyCode.S)){
            Salir();
        } else if (Input.GetKeyDown(KeyCode.A)){
            Abandonar();
        }
    }
    public void Pausa(){
        Time.timeScale = 0f;
        //botonPausa.SetActive(false);
        menuPausa.SetActive(true);
    }
    public void Reanudar(){
        Time.timeScale = 1f;
        //botonPausa.SetActive(true);
        menuPausa.SetActive(false);
    }
    public void Reiniciar(){
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Salir(){
        Debug.Log("Cerrando juego.");
        Application.Quit();
        SceneManager.LoadScene("MainMenu");
    }
    public void Abandonar(){
        SceneManager.LoadScene("GameOver");
    }
}
