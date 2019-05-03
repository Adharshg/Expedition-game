using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_menu_script : MonoBehaviour {

	public void StartGame () {
		SceneManager.LoadScene(3);
	}

	public void LoadMainMenu(){
		SceneManager.LoadScene(10);
	}
	
	public void LoadSettings () {
		SceneManager.LoadScene(8);
	}

	public void LoadAbout(){
		SceneManager.LoadScene(9);
	}

	public void LoadInstructions(){
		SceneManager.LoadScene(11);
	}
}
