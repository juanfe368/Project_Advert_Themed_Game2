using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
	public float spawnTime = 5f;		// The amount of time between each spawn.
	public float spawnDelay = 3f;		// The amount of time before spawning starts.
	public GameObject[] enemies;		// Array of enemy prefabs.
	public float velocidadGenerador = 5f;


	void Start ()
	{
		// Start calling the Spawn function repeatedly after a delay .
		InvokeRepeating("Spawn", spawnDelay, spawnTime);
	}

	void Update()
	{
		MovimientoGenerador ();
	}


	void Spawn ()
	{
		// Instantiate a random enemy.
		int enemyIndex = Random.Range(0, enemies.Length);
		//Instantiate(enemies[enemyIndex], transform.position, transform.rotation);
		Instantiate(enemies[enemyIndex], transform.position, Quaternion.Euler(0,180,0));//HACE QUE LOS ENEMIGOS SE GENEREN DE DERECHA A IZQUIERDA 14-11-2015-JFA
		

		// Play the spawning effect from all of the particle systems.
		foreach(ParticleSystem p in GetComponentsInChildren<ParticleSystem>())
		{
			p.Play();
		}
	}

	void MovimientoGenerador()
	{
		transform.Translate (velocidadGenerador*Time.deltaTime,0,0);
	}
}
