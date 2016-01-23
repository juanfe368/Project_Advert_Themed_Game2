using UnityEngine;
using System.Collections;

public class GeneradorVehiculos : MonoBehaviour {

	public GameObject[] arrayVehiculos;
	public float velocidadGeneradorCarro = 5f;
	public float tiempoInicial = 1f;
	public float tiempoConstante = 2f;
	private int posicionCarro;
	// Use this for initialization
	void Start () {
		InvokeRepeating("InvocarCars",tiempoInicial,tiempoConstante);
	}
	
	// Update is called once per frame
	void Update () {
		MovimientoGeneradorCarro();
	}

	void MovimientoGeneradorCarro(){
		transform.Translate (velocidadGeneradorCarro*Time.deltaTime*1,0,0);
	}

	void InvocarCars(){
        posicionCarro = Random.Range (0, 2);
        Debug.Log("VEHICULO ALEATORIO: "+posicionCarro);
		Instantiate(arrayVehiculos[posicionCarro],new Vector3(transform.position.x,transform.position.y+2,transform.position.z),Quaternion.identity);
	}
}
