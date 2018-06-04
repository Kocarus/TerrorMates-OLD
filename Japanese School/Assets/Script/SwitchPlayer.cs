using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPlayer : MonoBehaviour
{

	public GameObject Cowboy;

	public GameObject Horse;

	public GameObject Gunner;

	public GameObject EnemySpawnManager;

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Cowboy") || other.gameObject.CompareTag("Horse"))
		{
			// Horse.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			
			Cowboy.SetActive(false);
			Gunner.SetActive(true);

			Horse.GetComponent<HorseInput>().enabled = false; // Disable Horse Input Script
			
			// EnemyManager.GetComponent<EnemyManager>().enabled = true; // Enable Enemy Manager Script to start spawning Enemies
			
			EnemyManager[] enemies = EnemySpawnManager.GetComponents<EnemyManager>();
			foreach (EnemyManager enemy in enemies)
			{
				enemy.enabled = true;
			}
		}
	}

}