using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class coletaveis : MonoBehaviour
{
    
    public Text pontuacao;
    private int valorPontuacao;
    public GameObject sprite;
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            valorPontuacao = Convert.ToInt32(pontuacao.text) +1;
            pontuacao.text = ""+valorPontuacao; 
            print("pegou um quadrado");
            
            sprite.SetActive(false);
        }
       

    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}
