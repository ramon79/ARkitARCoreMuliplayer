using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletExplosionScript : MonoBehaviour {

	PhotonView view;
	public GameObject Explosion;


	// Use this for initialization
	void Start () {

		view = GetComponent<PhotonView> ();
		Destroy (gameObject, 1f);
		
	}
	
	void OnCollisionEnter (Collision Col)
	{

		GetComponent<SphereCollider> ().enabled = false;
		GetComponent<MeshRenderer> ().enabled = false;

		if (view.isMine) 
		{
			GameObject explosion = PhotonNetwork.Instantiate ("Explosion", transform.position, Quaternion.identity, 0) as GameObject;

		}
	}
}
