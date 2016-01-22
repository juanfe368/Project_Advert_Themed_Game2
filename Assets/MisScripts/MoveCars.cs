using UnityEngine;
using System.Collections;

public class MoveCars : MonoBehaviour {

	public float velocityCar = 10f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		MoveCar();
	}

	void MoveCar(){
		transform.Translate((velocityCar*Time.deltaTime)*-1,0,0);
	}

	void OnCollisionEnter(Collision collision) {
		if(collision.gameObject.tag=="Bullet"){
			Debug.Log ("Entro a la colisión");
		}
	}

	void Death(){

	}
}
