using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
	/** Executed before "Start()" */
	private void	Awake()
	{
		DontDestroyOnLoad(gameObject);
	}

	// Start is called before the first frame update
	void			Start()
	{
		Invoke("LoadGame", 1f);
	}

	// Update is called once per frame
	void			Update()
	{
		
	}

	void			LoadGame()
	{
		SceneManager.LoadScene(1);
	}
}
