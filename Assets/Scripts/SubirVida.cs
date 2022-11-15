using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubirVida : MonoBehaviour
{
    public Vida vi;
    public Image barraVida;
    public float vidaMaxima;
    public float health = 1;

    private void Start() {
        vi = FindObjectOfType<Vida>();
    }
    
    // Update is called once per frame
    public void Update() {
        
    }

    void  OnTriggerEnter (  Collider other   ){
        if (other.tag == "Player")//Si toca el tag "Player". 
        {
            //a.PlayOneShot(b,volumen);
            vi.health += health;
            Destroy(this.gameObject);
        }
    }
}
