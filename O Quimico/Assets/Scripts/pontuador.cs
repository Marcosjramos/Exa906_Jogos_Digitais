using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pontuador : MonoBehaviour {
    public Text contador;
    public int pontoGeral;
   
    private int gerador;
   // public Text contadorGameover;
	// Use this for initialization
	void Start () {
        
        //DontDestroyOnLoad(gameObject);
        pontoGeral = 0;




    }
	
	// Update is called once per frame
	void Update () {
        atualizaPontos();
        
       
	}
     void atualizaPontos() {
        
        pontoGeral += 0;//incrementa os valores da pontuação.
        contador.text = pontoGeral.ToString("F0");//insere o valor ja formatado na interface
        //contadorGameover.text = contador.text ;//exibi o placar no fim do jogo
    }

}
