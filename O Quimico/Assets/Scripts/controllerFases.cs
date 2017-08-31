using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class controllerFases : MonoBehaviour {
    public static int pontosTotaisFinais;
    public  Text valorpontos;
    public Text dicap1;
    public Text dicap2;
    public Text dicap3;
    public Text substancia;
    public Text substanciaCriadap1;
    public Text substanciaCriadap2;
    public Text substanciaCriadap3;
    

    void Start()
    {
        exibirPontos();
        geradorSubstancia();

        

    }
    void Update()
    {
        gamePlay();
        

    }
    public void exibirPontos() {
        if (SceneManager.GetActiveScene().buildIndex==2) {
            valorpontos.text = pontosTotaisFinais.ToString();
        }
     
    
    }
    public void geradorSubstancia() {//gera randomicamente um valor para inserir a substância que o jogador deverá inserir.
        int opcao = Random.Range(1,5);
        switch (opcao) {
           case 4:
               substancia.text = "Hidróxido de Sódio";
                dicap1.text = "Na";
                dicap2.text = "O";
                dicap3.text = "H";
                break;
            case 3:
                substancia.text = "Ácido Bromídrico";
                dicap1.text = "H";
                dicap2.text = "Br";
                dicap3.text = "";
                break;
            case 2:
                substancia.text = "Ácido Clorídrico";
                dicap1.text = "H";
                dicap2.text = "Cl";
                dicap3.text = "";
                break;
            case 1:
                substancia.text = "Ácido Fluorídrico";
                dicap1.text = "H";
                dicap2.text = "F";
                dicap3.text = "";
                break;

        }

    }

    public void gamePlay() {

       if (dicap3.text.Equals(""))
        {
            if (!substanciaCriadap2.text.Equals(""))
            {
                if (dicap1.text.Equals(substanciaCriadap1.text) && dicap2.text.Equals(substanciaCriadap2.text))
                {
                    substanciaCriadap1.text = "";
                    substanciaCriadap2.text = "";

                    geradorSubstancia();
                }
                else SceneManager.LoadScene("GameOver");
            }

      }
       if (!substanciaCriadap3.text.Equals(""))// se a terceira parte da dica não estiver vazia, indica que a substância possui 3 atomos.
       {
           if (dicap1.text.Equals(substanciaCriadap1.text) && dicap2.text.Equals(substanciaCriadap2.text) && dicap3.text.Equals(substanciaCriadap3.text))
            {
                substanciaCriadap1.text = "";
                substanciaCriadap2.text = "";
                substanciaCriadap3.text = "";
                 geradorSubstancia();
            }
             else SceneManager.LoadScene("GameOver");
        }
    }
       
        
}
