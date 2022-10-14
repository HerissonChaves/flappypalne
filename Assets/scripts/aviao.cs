using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aviao : MonoBehaviour {
	// Use this for initialization
	private Rigidbody2D fisica;
	private void Awake(){
		this.fisica=this.GetComponent<Rigidbody2D>(); //instanciando a variavel fisica
	}
	void Start () {
		
	}
	// Update is called once per frame
	private void Update () {
		if (Input.GetButtonDown("Fire1")) //reconhecer o click do mouse direito
		{
			this.Impulsionar(); // this chama o metodo ou objeto para ser executado 
		}
	}
	void Impulsionar(){
		int impulso = 10;
		//addFo
		this.fisica.AddForce(Vector2.up*impulso,ForceMode2D.Impulse); //adicionando força impulsiva para o vetor up
	}
}
