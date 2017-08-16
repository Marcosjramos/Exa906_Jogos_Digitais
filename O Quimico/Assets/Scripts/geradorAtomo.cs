using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class geradorAtomo : MonoBehaviour {
    public GameObject[] atomos;
    public float tempoDeGerar;
    private float tempoAtual;
    private int contador;//usado pra pegar a posicao do array
    private int posicao;
    private float y;

	// Use this for initialization
	void Start () {
        tempoAtual = 0;

       
        
	}
	
	// Update is called once per frame
	void Update () {
        tempoAtual += Time.deltaTime;
        if (tempoAtual >= tempoDeGerar) {
            tempoAtual = 0;
            posicao = Random.Range(1,85);
            y = posicao-5f;// altera o lugar de gerar randomicamente os objetos
            contador = Random.Range(0,6);
            


            GameObject tempPrefab = Instantiate(atomos[contador]) as GameObject;
            tempPrefab.transform.position = new Vector3(transform.position.x, y, transform.position.z);
            
        }
        
       
	}
}
