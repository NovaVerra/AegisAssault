using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	void	OnParticleCollision(GameObject CollisionObject)
	{
		print("Particles collided with enemt " + CollisionObject.name);
		Destroy(gameObject);
	}
}
