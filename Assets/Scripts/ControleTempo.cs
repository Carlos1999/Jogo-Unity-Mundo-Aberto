using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControleTempo : MonoBehaviour
{
    private float cronometro;
    private int tempoLimite;
    public int minutos;
    public int segundos;
    public Text cronometroText;
    public GameObject sucesso;
    public GameObject fracasso;
    public GameObject paiColetados;
    public Text coletados;
    private bool pararTempo;
    // Start is called before the first frame update
    void Start()
    {
        tempoLimite = 1;
        pararTempo = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(!pararTempo){
                
             cronometro += Time.deltaTime;
                if(cronometro >= tempoLimite){
                    cronometro = 0;
                    segundos -= 1;
                
               }
            if(segundos < 0 && minutos >0){
                if(!(minutos == 0 && segundos ==0)){
                segundos = 59;
                minutos -=1;
                }else{
                pararTempo = true;
                }
           
            }
        }

        cronometroText.text = minutos + " : " +segundos;

        if(Convert.ToInt32(coletados.text) == paiColetados.transform.childCount){
            Time.timeScale = 0f;
            sucesso.SetActive(true);
            pararTempo = true;
        }else if (minutos == 0 && segundos == 0){
            Time.timeScale = 0f;
            fracasso.SetActive(true);
            pararTempo = true;
        }


    }
}
