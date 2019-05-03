using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarSystemUI : MonoBehaviour {

	public GameObject text1;
	public GameObject text2;
	public GameObject text3;
	public GameObject text4;
	public GameObject text5;
	public GameObject text6;
	public GameObject text7;
	private float Timer = 0f;
	public GameObject TutorialScreen;

	// Use this for initialization
	void Start () {
		TutorialScreen.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		Timer += Time.deltaTime;

		if (Timer > 1f){
			text1.SetActive(true);
		}
		if (Timer > 4f){
			text1.SetActive(false);
			text2.SetActive(true);
		}
		if (Timer > 8f){
			text2.SetActive(false);
			text3.SetActive(true);
		}
		if (Timer > 12f){
			text3.SetActive(false);
			text4.SetActive(true);
		}
		if (Timer > 16f){
			text4.SetActive(false);
			text5.SetActive(true);
		}
		if (Timer > 20f){
			text5.SetActive(false);
			text6.SetActive(true);
		}
		if (Timer > 24f){
			text6.SetActive(false);
			text7.SetActive(true);
		}
		if (Timer > 28f){
			text4.SetActive(false);
			TutorialScreen.SetActive(true);
		}
				
	}
}
