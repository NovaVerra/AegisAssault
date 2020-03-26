using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
	[Tooltip("In seconds")][SerializeField]
	float		LevelLoadDelay = 2f;

	[Tooltip("Particles Effect Prefab")][SerializeField]
	GameObject	DeathFX;

	void	OnTriggerEnter(Collider TriggerEvent)
	{
		print("You died");
		StartDeathSequence();
	}

	void	StartDeathSequence()
	{
		gameObject.SendMessage("DisableControls");
		DeathFX.SetActive(true);
		Invoke("ReloadScene", LevelLoadDelay);
	}

	void	ReloadScene()	/** String rederence */
	{
		SceneManager.LoadScene(1);
	}
}
