using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
	/** Executed before "Start()" */
	private void	Awake()
	{
		int	NumOfMusicPlayers = FindObjectsOfType<MusicPlayer>().Length;
		if (NumOfMusicPlayers > 1)
		{
			Destroy(gameObject);
		}
		DontDestroyOnLoad(gameObject);
	}
}
