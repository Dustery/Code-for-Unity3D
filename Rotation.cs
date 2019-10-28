/*
Author: Oleksandr Kostynskyi
This code allows you to rotate the object using Arrows on your keyboards.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		var speed = 50;

		if(Input.GetKey(KeyCode.RightArrow)) // Rigth Arrow
		{
			this.transform.Rotate(new Vector3(speed * Time.deltaTime,0,0));
		}
		if(Input.GetKey(KeyCode.LeftArrow)) // Left Arrow
		{
			this.transform.Rotate(new Vector3(-speed * Time.deltaTime,0,0));
		}
		if(Input.GetKey(KeyCode.DownArrow)) // Down Arrow
		{
			this.transform.Rotate(new Vector3(0,-speed * Time.deltaTime,0));
		}
		if(Input.GetKey(KeyCode.UpArrow)) // Up Arrow
		{
			this.transform.Rotate(new Vector3(0,speed * Time.deltaTime,0));
		}
	}
}
