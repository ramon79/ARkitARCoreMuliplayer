using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class TankShootingScript : MonoBehaviour {

	PhotonView view;
	public GameObject Bullet;
	public int force = 30;
	private bool ShootBool = true;


	// Use this for initialization
	void Start () {

		view = GetComponent <PhotonView> ();
		
	}
	
	// Update is called once per frame
	void Update () {

		if ((view.isMine && (Input.GetKeyDown (KeyCode.Space) || CrossPlatformInputManager.GetButton("Fire"))) && ShootBool) 
		{

			ShootBool = false;
			StartCoroutine (SetShootBoolBack ());
			
			view.RPC ("shootBullet", PhotonTargets.All, transform.Find ("ShootPosition").transform.position, transform.Find ("ShootPosition").transform.rotation);
		}
		
	}

	IEnumerator SetShootBoolBack()
	{
		yield return new WaitForSeconds (0.5f);
		ShootBool = true;
	}
		

	[PunRPC]
	void shootBullet(Vector3 Pos, Quaternion quaat )
	{

		GameObject GO = Instantiate (Bullet, Pos, quaat) as GameObject;
		GO.GetComponent<Rigidbody> ().velocity = transform.TransformDirection (Vector3.forward * force);
		
	}
}
