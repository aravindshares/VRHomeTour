using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRObjectTrigger : MonoBehaviour {

	public GameObject objectToTrigger;
	public GameObject secondaryObject;
	private bool objectEnabled = false;

	// Use this for initialization
	void Start () {
		
		objectToTrigger.SetActive (false);
	}
	

	public void VRPointerEnter ()
	{
		objectEnabled = !objectEnabled;
		if (objectEnabled) {
			objectToTrigger.SetActive (true);
		} else {
			objectToTrigger.SetActive (false);
			if (secondaryObject != null) {
				secondaryObject.SetActive (false);
			}
		}
	}

	public void VRPointerExit ()
	{
		
	}
}
