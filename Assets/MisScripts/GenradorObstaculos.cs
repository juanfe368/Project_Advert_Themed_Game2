using UnityEngine;
using System.Collections;

public class GenradorObstaculos : MonoBehaviour {

    public GameObject objetoGenerar;
    public float xVelocity;
    public float initTimeGenerator;
    public float generationVelocity;
    public float defaultObjects;
	// Use this for initialization
	void Start () {
     
         for (int i = 0; i < defaultObjects; i++)
         {
            transform.Translate(xVelocity * i * 1/6, 0, 0);
            GenerarObstaculos();
            
        }
        defaultObjects = 0;
        InvokeRepeating("GenerarObstaculos",initTimeGenerator,generationVelocity);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(xVelocity*Time.deltaTime*1,0,0);
	}

    void GenerarObstaculos() {
        if (objetoGenerar!=null)
        {
            Instantiate(objetoGenerar,transform.position, Quaternion.identity);
        }
    }
}
