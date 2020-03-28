using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
	/** Game Configuration */
	[SerializeField] 
	int		ScorePerHit = 12;
	int		Score = 0;
	Text	ScoreText;

	// Start is called before the first frame update
	void	Start()
	{
		ScoreText = GetComponent<Text>();
		ScoreText.text = Score.ToString();
	}

	void	ScoreHit()
	{
		Score += ScorePerHit;
		ScoreText.text = Score.ToString();
	}
}
