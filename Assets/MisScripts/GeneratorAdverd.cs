using UnityEngine;
using System.Collections;

public class GeneratorAdverd : MonoBehaviour {

    public float timeInicial;
    public float timeFinal;
    public GameObject prefabAdverd;

	// Use this for initialization
	void Start () {
        InvokeRepeating("GenerateAdverd", timeInicial, timeFinal);
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    void GenerateAdverd() {
        Instantiate(prefabAdverd, transform.position, Quaternion.identity);
    }
}
