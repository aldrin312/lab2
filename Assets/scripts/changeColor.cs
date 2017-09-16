using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class changeColor : MonoBehaviour {

	public GameObject img1;
	public GameObject img2;
	public GameObject imgclick;

	void OnMouseDown()
	{
		imgclick.SetActive(true);
		img1.SetActive(false);
		img2.SetActive(false);
	}
}
