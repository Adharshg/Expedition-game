using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

	public float Movspeed = 15;
	private Vector3 moveDir;

	void Update () {
		moveDir = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;	
	}

	void FixedUpdate(){
		this.GetComponent<Rigidbody>().MovePosition(this.GetComponent<Rigidbody>().position + transform.TransformDirection(moveDir) * Movspeed * Time.deltaTime);
	}
}
