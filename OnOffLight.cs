
/*
Author: Oleksandr Kostynskyi
This code turns the lights on and off. 
Just add this code to your source of light.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOffLight : MonoBehaviour {

	private Light myLight;
	// Use this for initialization
	void Start () {
		myLight = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyUp(KeyCode.Alpha1)) // here you can set key you want. For example me here I have'1'
		{
			myLight.enabled = !myLight.enabled;
		}

	}
}