using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnPoint;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            Disparar();
        }
    }

    private void Disparar(){
        RaycastHit2D raycastHit2D = Physics2D.Raycast(spawnPoint.position, spawnPoint.right);

        if(raycastHit2D){
            if(raycastHit2D.transform.CompareTag("enemigo")){
                //raycastHit2D.transform.GetComponent<enemigo>().TomarDano(1);
            }
        }
    }
}
