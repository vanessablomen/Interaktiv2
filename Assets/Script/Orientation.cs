using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orientation : MonoBehaviour

{

	[Header("References:")]
	public Transform cameraTransform;

	[Space(10)]
	[Header("Settings:")]
	public float mouseSensitivity = 100f;


	private float xRotation = 0f;
	private float yRotation = 0f;
	void Start()
	{
		Cursor.lockState = CursorLockMode.Locked;
	}

	// Update is called once per frame

	private void Update()
	{
		float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
		float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
	

		xRotation -= mouseY;
		yRotation += mouseX;

		xRotation = Mathf.Clamp(xRotation, -90f, 90f);

		cameraTransform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);

	}

}
