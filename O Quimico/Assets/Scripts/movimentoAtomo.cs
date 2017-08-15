using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentoAtomo : MonoBehaviour {
   public Rigidbody2D corpoAtomo;
   public float deslocamento;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        corpoAtomo.AddForce(new Vector2(deslocamento, 0));//adiciona um deslocamento a esquerda quando criado

        if (transform.position.x<=-200) {//destroi o objeto criado na posição -100
            Destruir();
        }
		
	}
    private void Destruir() {
        Destroy(transform.gameObject);
    }
}
