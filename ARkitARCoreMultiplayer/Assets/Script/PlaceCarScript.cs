using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityARInterface;
using UnityEngine.SceneManagement;

public class PlaceCarScript : MonoBehaviour {


	public Button PlaceGameObjectBtn;
	
	private ARPointCloudVisualizer ARPointCloudVisualizer;
	private ARPlaneVisualizer ARPlaneVisualizer;
	public  GameObject colorsPanel;
	public  GameObject lightsPanel;


	public void onClickPlaceGameObject ()
	{
		var planes = GameObject.FindGameObjectsWithTag ("planeTag");
		var particles = GameObject.FindGameObjectsWithTag ("particleTag");

		foreach (var plane in planes) 
		{
			Destroy (plane);
		}

		foreach (var particle in particles) 
		{
			Destroy (particle);
		}

		ARPointCloudVisualizer = GameObject.Find ("AR Root").GetComponent<ARPointCloudVisualizer> ();
		ARPlaneVisualizer = GameObject.Find ("AR Root").GetComponent<ARPlaneVisualizer> ();

		Destroy (ARPointCloudVisualizer);
		Destroy (ARPlaneVisualizer);
		Destroy (GameObject.Find("FocusSquare"));

		
		PlaceGameObjectBtn.gameObject.SetActive (false);
		colorsPanel.gameObject.SetActive(true);
		lightsPanel.gameObject.SetActive(true);
	}
}
