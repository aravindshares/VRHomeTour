using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamOnButton : MonoBehaviour
{
	public float speed = 3.0F;
	private CharacterController myCharCon;
	private Transform vrCam;

	private bool moveStart;

	// Use this for initialization
	void Start()
	{

		myCharCon = GetComponent<CharacterController>();
		vrCam = Camera.main.transform;



	}

	// Update is called once per frame
	void Update()
	{

		if (Input.GetButtonDown("Fire1"))
		{

			moveStart = !moveStart;
		}
		if (moveStart)
		{
			Vector3 forward = vrCam.TransformDirection(Vector3.forward);
			myCharCon.SimpleMove(forward * speed);
		}

	}
}
