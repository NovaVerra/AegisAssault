using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	[SerializeField] GameObject	EnemyDeathFX;
	[SerializeField] Transform	Parent;

	// Start is called before the first frame update
	void Start()
	{
		AddNonTriggerBoxCollider();
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

	void	OnParticleCollision(GameObject CollisionObject)
	{
		print("Particles collided with enemt " + CollisionObject.name);
		GameObject FX = Instantiate(EnemyDeathFX, transform.position, Quaternion.identity);
		FX.transform.parent = Parent;
		Destroy(gameObject);
	}
}
