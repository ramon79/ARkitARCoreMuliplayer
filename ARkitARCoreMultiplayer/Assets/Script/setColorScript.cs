using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setColorScript : MonoBehaviour {

	// Use this for initialization
	public MeshRenderer[] objects;

	public void setYellow()
	{
		for (int i =0; i<objects.Length; i++)
		{
			objects[i].material.color = new Color (1, 0.92f, 0.016f, 1);
		}

	}

	public void setGreen()
	{
		for (int i =0; i<objects.Length; i++)
		{
			objects[i].material.color = new Color (0, 1, 0, 1);
		}
	}

	public void setRed()
	{
		for (int i =0; i<objects.Length; i++)
		{
			objects[i].material.color = new Color (1, 0, 0, 1);
		}
		
	}
	public void setBlack()
	{
		for (int i =0; i<objects.Length; i++)
		{
			objects[i].material.color = new Color (0, 0, 0, 1);
		}
	}
	public void setBlue()
	{
		for (int i =0; i<objects.Length; i++)
		{
			objects[i].material.color = new Color (0, 0, 1, 1);
		}
		
	}

}
