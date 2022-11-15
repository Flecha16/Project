using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject MyTarget;
    public NavMeshAgent MyAgent;
    public int range;
    public int damage = 1;

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(this.transform.position, MyTarget.transform.position);
        print ("Distance to other: " + dist);
        if (dist < range){
            MyAgent.destination = MyTarget.transform.position;
        }
    }
    void OnCollisionEnter(Collision collition){
        if(collition.gameObject.CompareTag("Player")){
           Vida nuevo = collition.gameObject.GetComponent<Vida>();
           nuevo.TakeDamage(damage);
        }
    }
}
