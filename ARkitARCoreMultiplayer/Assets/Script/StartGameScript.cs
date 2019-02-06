using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGameScript : MonoBehaviour {

	public Button StartGameButton;
	public GameObject NetworkManagerObject;
	public GameObject placeNewBtn;


	// Use this for initialization
	void Start () {

		StartGameButton.onClick.AddListener (startGameFunc);
	}
	
	void startGameFunc()
	{
		StartGameButton.gameObject.SetActive (false);
		NetworkManagerObject.SetActive (true);
		placeNewBtn.gameObject.SetActive (false);

	}
}
