using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
	/** Executed before "Start()" */
	private void	Awake()
	{
		DontDestroyOnLoad(gameObject);
	}
}
