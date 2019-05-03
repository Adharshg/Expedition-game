using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Indian : MonoBehaviour {

	public GameObject uiObject;

	void Start () {
		uiObject.SetActive(false);
	}
	
	void OnTriggerEnter (Collider other){
		if (other.gameObject.tag == "Player")
			uiObject.SetActive(true);
	}

	void OnTriggerExit (Collider other){
		if (other.gameObject.tag == "Player")
			uiObject.SetActive(false);
	}
}
