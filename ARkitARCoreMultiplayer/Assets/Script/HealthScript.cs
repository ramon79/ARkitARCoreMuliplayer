using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour {

	public int health = 100;
	PhotonView view;
	Text TxtHealth;
	Text TxtHealthOther;
	Image healthBar;
	Image healthBarOther;
	private NetworkManagerScript NetworkManagerScript;
	//public int score;


	// Use this for initialization
	void Start () {

//		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
//		if (gameControllerObject != null) 
//		{
//			NetworkManagerScript = gameControllerObject.GetComponent <NetworkManagerScript>();
//		}

		view = GetComponent<PhotonView> ();
		TxtHealth = GameObject.Find ("TxtHealth").GetComponent<Text> ();
		TxtHealthOther = GameObject.Find ("TxtHealthOther").GetComponent<Text> ();

		healthBar = GameObject.Find ("HealthBar").GetComponent<Image> ();
		healthBarOther = GameObject.Find ("HealthBarOther").GetComponent<Image> ();

		healthBar.fillAmount = health / 100f;
		healthBarOther.fillAmount = health / 100f;
	
	}

	void OnCollisionEnter (Collision Col)
	{

		if (Col.gameObject.tag == "Bullet" && view.isMine) 
		{
			health -= 10;
			TxtHealth.text = "ME: " + health + "%";
			view.RPC ("damageOther", PhotonTargets.Others, health);
			healthBar.fillAmount = health / 100f;
		}

	}


	// Update is called once per frame
	void Update () {

		if (health <= 0) 
		{
			healthBar.fillAmount = 100f;
			healthBarOther.fillAmount = 100f;
			view.RPC ("destroyGA", PhotonTargets.All);
		}
		
	}

	[PunRPC]
	void destroyGA ()
	{
		//NetworkManagerScript.AddScore (score+1);
		Destroy (gameObject);
	}


	[PunRPC]
	void damageOther(int health)
	{
		TxtHealthOther.text = "OTHER: " + health + "%";
		healthBarOther.fillAmount = health / 100f;
	}
}
