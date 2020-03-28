using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
	/** Game Configuration */
	int		Score = 0;
	Text	ScoreText;

	// Start is called before the first frame update
	void	Start()
	{
		ScoreText = GetComponent<Text>();
		ScoreText.text = Score.ToString();
	}

	public void	ScoreHit(int ScorePerHit)
	{
		Score = Score + ScorePerHit;
		ScoreText.text = Score.ToString();
	}
}

// IMPLEMENTED FEATURE C