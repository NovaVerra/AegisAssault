using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour
{
	/** Game Configuration */
	[Tooltip("in ms^-1")][SerializeField] float	X_Speed = 4f;

	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		float	X_Throw = CrossPlatformInputManager.GetAxis("Horizontal");
		float	Y_Throw = CrossPlatformInputManager.GetAxis("Vertical");
		float	X_Offset_ThisFrame = X_Throw * X_Speed * Time.deltaTime;
	}
}
