using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHunting : MonoBehaviour
{
	Transform player;
	// PlayerHealth playerHealth;
	// EnemyHealth enemyHealth;

	UnityEngine.AI.NavMeshAgent nav;

	Animator anim;

	void Awake()
	{
		nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
		anim = GetComponent<Animator>();

		if (GameObject.FindGameObjectWithTag("Player"))
		{
			player = GameObject.FindGameObjectWithTag("Player").transform; 
			// anim.SetFloat("Speed", 0.4f);
		}
				
		// playerHealth = player.GetComponent <PlayerHealth> ();
		// enemyHealth = GetComponent <EnemyHealth> (); 
		// anim.SetBool("Crouch", true);
	}

	
	void Update()
	{
		if (player)
		{
			anim.SetFloat("Speed", 0.4f);
			nav.SetDestination(player.position);
		}

		// if(enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
		// {
		// }
		// else
		// {
		//    nav.enabled = false;
		// }
	}

}
