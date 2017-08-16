using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void menuinicial() {
        SceneManager.LoadScene("MenuInicial");

    }
    public void jogar() {
        SceneManager.LoadScene("missao1v2");
    }
    public void sair() {
        Application.Quit();
    }
}
