using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
	[SerializeField] GameObject	EnemyDeathFX;
	[SerializeField] Transform	Parent;
	[SerializeField] int		ScorePerHit = 12;
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

	// Update is called once per frame
	void Update()
	{

	}

	/** turned off collision on RIGHT BEAM */
	void	OnParticleCollision(GameObject CollisionObject)
	{
		print("Particles collided with enemt " + CollisionObject.name);
		GameObject FX = Instantiate(EnemyDeathFX, transform.position, Quaternion.identity);
		Destroy(gameObject);
		FX.transform.parent = Parent;
		ScoreBoard.ScoreHit(ScorePerHit);
	}
}
