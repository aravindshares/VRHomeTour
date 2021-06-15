using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRTextureTrigger : MonoBehaviour {
	public GameObject[] targetObjects;
	public Texture[] textures;


	// Use this for initialization
	void Start () {

	}
	

	public void Texture1Switch ()
	{
		for(int i = 0; i < targetObjects.Length; i++)
		{
			targetObjects[i].GetComponent<Renderer>().material.SetTexture ("_MainTex", textures[0]);
		}


	}

	public void Texture2Switch ()
	{
		for(int i = 0; i < targetObjects.Length; i++)
		{
			targetObjects[i].GetComponent<Renderer>().material.SetTexture ("_MainTex", textures[1]);
		}
	}

	public void Texture3Switch ()
	{
		for(int i = 0; i < targetObjects.Length; i++)
		{
			targetObjects[i].GetComponent<Renderer>().material.SetTexture ("_MainTex", textures[2]);
		}
	}

	public void Texture4Switch ()
	{
		for(int i = 0; i < targetObjects.Length; i++)
		{
			targetObjects[i].GetComponent<Renderer>().material.SetTexture ("_MainTex", textures[3]);
		}
	}
}
