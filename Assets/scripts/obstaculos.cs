using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculos : MonoBehaviour {
	[SerializeField] private float velocidade_obstaculo=0.2f;
	void Update () {
		this.transform.Translate(Vector3.left*velocidade_obstaculo);
	}
}
