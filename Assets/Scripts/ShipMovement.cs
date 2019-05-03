using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour {

	public float Movespeed = 400f;
	public float Flyspeed = 600f;
	public float turnSpeed = 60f;
	public float fallSpeed = -10f;
	public bool isFly = false;

	Transform myT;

	// Use this for initialization
	void Awake () {
		myT = transform;
	}

	void Start(){
		Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update () {
		if ((Input.GetAxis("Vertical1") > 0)){
			myT.position += myT.forward * Movespeed * Time.deltaTime * Input.GetAxis("Vertical1");
			if (Input.GetKey(KeyCode.LeftShift)){
				Movespeed = Flyspeed;
			}
			else{
				Movespeed = Movespeed;
			}
			
			if (Input.GetKeyUp(KeyCode.LeftShift)){
				Movespeed = 400f;
			}
		}

		Turn();
		//UpDown();
	}

	void Thrust(){
		if ((Input.GetAxis("Vertical1") > 0))
			myT.position += myT.forward * Movespeed * Time.deltaTime * Input.GetAxis("Vertical1");
		
	}

	/*void UpDown(){
		if (Input.GetAxis("UpDown") != 0)
			myT.position += myT.up * fallSpeed * Time.deltaTime * Input.GetAxis("UpDown");
	}*/

	void Turn(){
		float yaw = turnSpeed * Time.deltaTime * Input.GetAxis("Horizontal");
		float pitch = turnSpeed * Time.deltaTime * Input.GetAxis("Pitch");
		float roll = - turnSpeed * Time.deltaTime * Input.GetAxis("Roll");
		
		myT.Rotate( pitch, yaw, roll);
	}

}
