using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Vida : MonoBehaviour
{
    public Vidas vi;

    public Image barraVida;
    public float vidaMaxima;

    public float health;

    private void Start() {
        vi = FindObjectOfType<Vidas>();
    }

    public void Update() {
        vi.health = health;
        barraVida.fillAmount = health/vidaMaxima;
    }

    public void TakeDamage(int damage){
        health -= damage;
        vi.health = health;

        if (health <= 0){
            SceneManager.LoadScene(2);
        }
    }

}
