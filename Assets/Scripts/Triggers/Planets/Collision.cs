using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Collision : MonoBehaviour {

	public int SceneNumber;
	
	void OnTriggerEnter (Collider other){
		if (other.gameObject.tag == "Player")
			SceneManager.LoadScene(SceneNumber);
	}

	void OnTriggerExit (Collider other){
		if (other.gameObject.tag == "Player");
	}
}
