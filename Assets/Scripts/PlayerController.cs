using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour
{
	/** Game Configuration */
	[Tooltip("in ms^-1")][SerializeField]
	float	MovementSpeed = 4f;
	[SerializeField]
	float	X_Range = 10f;
	[SerializeField]
	float	Y_Range = 6.5f;

	// Start is called before the first frame update
	void	Start()
	{

	}

	// Update is called once per frame
	void	Update()
	{
		ProcessTransform();
		ProcessRotation();
	}

	void	ProcessTransform()
	{
		/** Read and bind user input */
		float	X_Axis = CrossPlatformInputManager.GetAxis("Horizontal");
		float	Y_Axis = CrossPlatformInputManager.GetAxis("Vertical");
	
		/** Calculating offset */
		float	X_Offset = X_Axis * MovementSpeed * Time.deltaTime;
		float	Y_Offset = Y_Axis * MovementSpeed * Time.deltaTime;
	
		/** Calculating new position of ship */
		float	X_NewVector = transform.localPosition.x + X_Offset;
		float	Y_NewVector = transform.localPosition.y + Y_Offset;
	
		/** Restricting the movement within camera bounds */
		X_NewVector = Mathf.Clamp(X_NewVector, -X_Range, X_Range);
		Y_NewVector = Mathf.Clamp(Y_NewVector, -Y_Range, Y_Range);

		/** Moving the ship */
		transform.localPosition = new Vector3(X_NewVector, Y_NewVector, transform.localPosition.z);
	}
	
	void	ProcessRotation()
	{
		transform.localRotation = Quaternion.Euler(-30f, 30f, 0f);
	}
}
