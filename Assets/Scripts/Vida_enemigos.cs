// Converted from UnityScript to C# at http://www.M2H.nl/files/js_to_c.php - by Mike Hergaarden
// Do test the code! You usually need to change a few small bits.

using UnityEngine;
using System.Collections;

public class Vida_enemigos : MonoBehaviour {
// Sistema de vida para enemigos.
[SerializeField] private Animator enemyAnimator;
public int balas_disparadas = 0;  //Balas disparadas y que le han dado al enemigo.
public int balas_necesarias = 2; //Las balas que se necesitan para matar al enemigo.
public float puntajeDeObjeto = 1.0f;
public puntaje pt;

private void Start() {
    pt = FindObjectOfType<puntaje>();
    if (enemyAnimator == null){
        enemyAnimator = GetComponentInChildren<Animator>();
    }
}

void  OnTriggerEnter (  Collider other   ){
    if (other.tag == "bala")//Si toca el tag "bala". 
    {
        balas_disparadas += 1; //Suma 1 a las balas disparadas.
        Destroy(other.gameObject);//Destruye la bala.
        if (balas_necesarias == balas_disparadas)//Si han tocado al jugador el número de balas necesarias.
        {
            pt.puntos += puntajeDeObjeto;
            enemyAnimator.SetTrigger("Muerto");
            Destroy(this.gameObject,1.7f);//Destruye este objeto.
            Destroy(other.gameObject);//Destruye la bala.
        }
    }
}
}