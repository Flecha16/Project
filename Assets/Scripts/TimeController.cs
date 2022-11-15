using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeController : MonoBehaviour
{
    [SerializeField] int min, seg;
    [SerializeField] Text tiempo;

    private float restante;
    private bool enMarcha;
    public Vida vi;
    public puntaje pt;

    private void Start() {
        vi = FindObjectOfType<Vida>();
        pt = FindObjectOfType<puntaje>();
    }

    private void Awake(){
        restante = (min * 60) + seg;
        enMarcha = true;
    }
    // Update is called once per frame
    void Update()
    {
        if(enMarcha){
            restante -= Time.deltaTime;
            if (restante < 1){
                if(pt.puntos >= 35){
                    enMarcha = false;
                    SceneManager.LoadScene(3);
                } else {
                    enMarcha = false;
                    SceneManager.LoadScene("GameOver");
                }
            }
            int tempMin = Mathf.FloorToInt(restante / 60);
            int tempSeg = Mathf.FloorToInt(restante % 60);
            tiempo.text = string.Format("{00:00}:{01:00}", tempMin, tempSeg);
        }
    }
}
