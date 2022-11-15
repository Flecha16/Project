using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    [SerializeField] private Animator gunAnimator;
    public GameObject bullet;
    public Transform spawnPoint;
    public AudioSource a;
    public AudioClip b;
    public AudioClip s;
    public Balas ba;

    public float shotForce = 1500;
    public float shotRate = 0.5f;
    private float shotRateTime = 0;
    public float volumen = 1f;

    private void Start() {
        ba = FindObjectOfType<Balas>();
        if (gunAnimator == null)
            gunAnimator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")){
            if(ba.balas > 0){
                a.PlayOneShot(s,volumen);
                ba.balas -= 1;
            
                if (Time.time > shotRateTime){
                    GameObject newBullet;

                    newBullet = Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);

                    newBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward*shotForce);

                    shotRateTime = Time.time + shotRate;

                    Destroy(newBullet, 2);
                }
            } else {
                a.PlayOneShot(b,volumen);
            }
        }
    }
}
