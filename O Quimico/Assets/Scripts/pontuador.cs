using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pontuador : MonoBehaviour {
    public Text contador;
    private float pontos;

	// Use this for initialization
	void Start () {
        pontos = 0;
	}
	
	// Update is called once per frame
	void Update () {
        pontos += Time.deltaTime;
        contador.text = pontos.ToString("F2");
	}
}
