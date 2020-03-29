using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
	[SerializeField] GameObject	EnemyDeathFX;
	[SerializeField] Transform	Parent;
	[SerializeField] int		Hits = 10;
	[SerializeField] int		ScorePerKill = 12;
	
	ScoreBoard	ScoreBoard;

	// Start is called before the first frame update
	void Start()
	{
		AddNonTriggerBoxCollider();
		ScoreBoard = FindObjectOfType<ScoreBoard>();
	}

	void	AddNonTriggerBoxCollider()
	{
		Collider	NonTriggerBoxCollider = gameObject.AddComponent<BoxCollider>();
		NonTriggerBoxCollider.isTrigger = false;
	}

	/** turned off collision on RIGHT BEAM */
	void	OnParticleCollision(GameObject CollisionObject)
	{
		if (Hits > 0)
		{
			ScoreBoard.ScoreHit(ScorePerKill);
			Hits--;
		}
		else
		{
			KillEnemy();
		}
	}

	void	KillEnemy()
	{
		GameObject FX = Instantiate(EnemyDeathFX, transform.position, Quaternion.identity);
		FX.transform.parent = Parent;
		Destroy(gameObject);
	}
}
