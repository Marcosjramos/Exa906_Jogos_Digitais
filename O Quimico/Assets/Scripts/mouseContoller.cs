using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class mouseContoller : MonoBehaviour {
    
    public int pontos;
    public GameObject obj;
    pontuador pontosTotal;
    controllerFases controller;
	// Use this for initialization
	void Start () {
        pontosTotal = GameObject.Find("PontuadorTotal").GetComponent<pontuador>();
        controller = GameObject.Find("controllerFases").GetComponent<controllerFases>();
	}
    private void atualizaPontuacao() {
        if (obj.gameObject.CompareTag("H"))
        {
            Destroy(obj);
            pontos += 1;
            pontosTotal.pontoGeral += pontos;
            controllerFases.pontosTotaisFinais += pontosTotal.pontoGeral;
            if (controller.substanciaCriadap1.text.Equals("")) {//verifica se ja existe caracter inserido na primeira parte, se não exitir ele insere.
                controller.substanciaCriadap1.text = "H";
            } else if (controller.substanciaCriadap2.text.Equals("")) {// verifica se ja existe cracter inserido na segunda parte, se não existir ele insere.
                controller.substanciaCriadap2.text = "H";
            } else if (controller.substanciaCriadap3.text.Equals("")) {
                controller.substanciaCriadap3.text = "H";
            }

            

        } else if (obj.gameObject.CompareTag("C")) {
            Destroy(obj);
            pontos += 6;
            pontosTotal.pontoGeral += pontos;
              controllerFases.pontosTotaisFinais += pontosTotal.pontoGeral;
            if (controller.substanciaCriadap1.text.Equals(""))
            {//verifica se ja existe caracter inserido na primeira parte, se não exitir ele insere.
                controller.substanciaCriadap1.text = "C";
            }
            else if (controller.substanciaCriadap2.text.Equals(""))
            {// verifica se ja existe cracter inserido na segunda parte, se não existir ele insere.
                controller.substanciaCriadap2.text = "C";
            }
            else if (controller.substanciaCriadap3.text.Equals(""))
            {
                controller.substanciaCriadap3.text = "C";
            }

        } else if (obj.gameObject.CompareTag("Cl")) {
            Destroy(obj);
            pontos += (int)17;
            pontosTotal.pontoGeral += pontos;
             controllerFases.pontosTotaisFinais += pontosTotal.pontoGeral;
            if (controller.substanciaCriadap1.text.Equals(""))
            {//verifica se ja existe caracter inserido na primeira parte, se não exitir ele insere.
                controller.substanciaCriadap1.text = "Cl";
            }
            else if (controller.substanciaCriadap2.text.Equals(""))
            {// verifica se ja existe cracter inserido na segunda parte, se não existir ele insere.
                controller.substanciaCriadap2.text = "Cl";
            }
            else if (controller.substanciaCriadap3.text.Equals(""))
            {
                controller.substanciaCriadap3.text = "Cl";
            }

        } else if (obj.gameObject.CompareTag("F")) {
            Destroy(obj);
            pontos += 9;
            pontosTotal.pontoGeral += pontos;
             controllerFases.pontosTotaisFinais += pontosTotal.pontoGeral;
            if (controller.substanciaCriadap1.text.Equals(""))
            {//verifica se ja existe caracter inserido na primeira parte, se não exitir ele insere.
                controller.substanciaCriadap1.text = "F";
            }
            else if (controller.substanciaCriadap2.text.Equals(""))
            {// verifica se ja existe cracter inserido na segunda parte, se não existir ele insere.
                controller.substanciaCriadap2.text = "F";
            }
            else if (controller.substanciaCriadap3.text.Equals(""))
            {
                controller.substanciaCriadap3.text = "F";
            }

        } else if (obj.gameObject.CompareTag("N")) {
            Destroy(obj);
            pontos += 7;
            pontosTotal.pontoGeral += pontos;
              controllerFases.pontosTotaisFinais += pontosTotal.pontoGeral;
            if (controller.substanciaCriadap1.text.Equals(""))
            {//verifica se ja existe caracter inserido na primeira parte, se não exitir ele insere.
                controller.substanciaCriadap1.text = "N";
            }
            else if (controller.substanciaCriadap2.text.Equals(""))
            {// verifica se ja existe cracter inserido na segunda parte, se não existir ele insere.
                controller.substanciaCriadap2.text = "N";
            }
            else if (controller.substanciaCriadap3.text.Equals(""))
            {
                controller.substanciaCriadap3.text = "N";
            }

        } else if (obj.gameObject.CompareTag("Na")) {
            Destroy(obj);
            pontos += 11;
            pontosTotal.pontoGeral += pontos;
              controllerFases.pontosTotaisFinais += pontosTotal.pontoGeral;
            if (controller.substanciaCriadap1.text.Equals(""))
            {//verifica se ja existe caracter inserido na primeira parte, se não exitir ele insere.
                controller.substanciaCriadap1.text = "Na";
            }
            else if (controller.substanciaCriadap2.text.Equals(""))
            {// verifica se ja existe cracter inserido na segunda parte, se não existir ele insere.
                controller.substanciaCriadap2.text = "Na";
            }
            else if (controller.substanciaCriadap3.text.Equals(""))
            {
                controller.substanciaCriadap3.text = "Na";
            }

        } else if (obj.gameObject.CompareTag("O")) {
            Destroy(obj);
            pontos += 8;
            pontosTotal.pontoGeral += pontos;
             controllerFases.pontosTotaisFinais += pontosTotal.pontoGeral;
            if (controller.substanciaCriadap1.text.Equals(""))
            {//verifica se ja existe caracter inserido na primeira parte, se não exitir ele insere.
                controller.substanciaCriadap1.text = "O";
            }
            else if (controller.substanciaCriadap2.text.Equals(""))
            {// verifica se ja existe cracter inserido na segunda parte, se não existir ele insere.
                controller.substanciaCriadap2.text = "O";
            }
            else if (controller.substanciaCriadap3.text.Equals(""))
            {
                controller.substanciaCriadap3.text = "O";
            }
        }
        else if (obj.gameObject.CompareTag("Br"))
        {
            Destroy(obj);
            pontos += 35;
            pontosTotal.pontoGeral += pontos;
             controllerFases.pontosTotaisFinais += pontosTotal.pontoGeral;
            if (controller.substanciaCriadap1.text.Equals(""))
            {//verifica se ja existe caracter inserido na primeira parte, se não exitir ele insere.
                controller.substanciaCriadap1.text = "Br";
            }
            else if (controller.substanciaCriadap2.text.Equals(""))
            {// verifica se ja existe cracter inserido na segunda parte, se não existir ele insere.
                controller.substanciaCriadap2.text = "Br";
            }
            else if (controller.substanciaCriadap3.text.Equals(""))
            {
                controller.substanciaCriadap3.text = "Br";
            }

        }
        
       controllerFases.pontosTotaisFinais = pontosTotal.pontoGeral;
    }


	// Update is called once per frame
	void Update () {
        
	}
    void OnMouseDown()
    {

        atualizaPontuacao();
        
    }


}
