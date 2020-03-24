using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		float	HorizontalThrow = CrossPlatformInputManager.GetAxis("Horizontal");
		print(HorizontalThrow);
	}
}
