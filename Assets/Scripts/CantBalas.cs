using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CantBalas : MonoBehaviour
{
    public AudioSource a;
    public AudioClip b;
    public Balas ba;
    public float balas = 10;
    public float volumen = 1f;

    private void Start() {
        ba = FindObjectOfType<Balas>();
    }

    void  OnTriggerEnter (  Collider other   ){
        if (other.tag == "Player")//Si toca el tag "Player". 
        {
            a.PlayOneShot(b,volumen);
            ba.balas += balas;
            Destroy(this.gameObject);
        }
    }
    
}
