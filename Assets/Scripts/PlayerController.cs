﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour
{
	/** Game Configuration */
	/** Dictates how fast the ship moves based on user input */
	[Tooltip("in ms^-1")][SerializeField]
	float	MovementSpeed = 15f;

	/** Range for ship movement relative to camera */
	[SerializeField] float	X_Range = 10f;
	[SerializeField] float	Y_Range = 6.5f;
	
	/** Relationship between ship position and pitch */
	[SerializeField] float	PositionPitchFactor = 5f;
	
	/** Element that gives the ship a more realistic feeling when pitch/yaw/rolling */
	[SerializeField] float	InputMovementAmplifier = 25f;

	float	X_Axis, Y_Axis;

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
		X_Axis = CrossPlatformInputManager.GetAxis("Horizontal");
		Y_Axis = CrossPlatformInputManager.GetAxis("Vertical");
	
		/** Calculating offset */
		float	X_Offset = X_Axis * MovementSpeed * Time.deltaTime;
		float	Y_Offset = Y_Axis * MovementSpeed * Time.deltaTime;
	
		/** Calculating new position of ship */
		float	X_NewPos = transform.localPosition.x + X_Offset;
		float	Y_NewPos = transform.localPosition.y + Y_Offset;
	
		/** Restricting the movement within camera bounds */
		X_NewPos = Mathf.Clamp(X_NewPos, -X_Range, X_Range);
		Y_NewPos = Mathf.Clamp(Y_NewPos, -Y_Range, Y_Range);

		/** Moving the ship */
		transform.localPosition = new Vector3(X_NewPos, Y_NewPos, transform.localPosition.z);
	}
	
	void	ProcessRotation()
	{
		/** Rotation set that is relative to ship position */
		float	PitchAtPos = transform.localPosition.y * (-PositionPitchFactor);
		float	YawAtPos = transform.localPosition.x * PositionPitchFactor;
	
		/** Rotation set that is amplified by user input */
		float	PitchWithInputAmplifier = (-Y_Axis) * InputMovementAmplifier;
		float	YawWithInputAmplifier = X_Axis * InputMovementAmplifier;
		float	RollWithInputAmplifier = (-X_Axis) * InputMovementAmplifier;

		/** Compounding rotation effects */
		float	Pitch = PitchAtPos + PitchWithInputAmplifier;
		float	Yaw = YawAtPos + YawWithInputAmplifier;
		float	Roll = RollWithInputAmplifier;

		/** Set rotation */
		transform.localRotation = Quaternion.Euler(Pitch, Yaw, Roll);
	}
}
