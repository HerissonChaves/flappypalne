using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeObstaculos : MonoBehaviour {

	[SerializeField] private float tempoParaGerar;
	private float cronometro;
	[SerializeField] GameObject obstaculos;
	void Awake(){
		this.cronometro=this.tempoParaGerar;
	}

	void Update () {
		this.cronometro-=Time.deltaTime;
		if(cronometro<0){
			GameObject.Instantiate(this.obstaculos,this.transform.position,Quaternion.identity); //cria os obstaculos
			this.cronometro=this.tempoParaGerar; // reinicia o cronometro
		}
		
	}
}
