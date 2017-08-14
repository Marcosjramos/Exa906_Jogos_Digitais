using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class geradorAtomo : MonoBehaviour {
    public GameObject atomoH;
    public float tempoDeGerar;
    public float tempoAtual;

	// Use this for initialization
	void Start () {
        tempoAtual = 0;
	}
	
	// Update is called once per frame
	void Update () {
        tempoAtual += Time.deltaTime;
        if (tempoAtual >= tempoDeGerar) {
        }
        tempoAtual = 0;
        GameObject tempPrefab = Instantiate(atomoH) as GameObject;
       
	}
}
