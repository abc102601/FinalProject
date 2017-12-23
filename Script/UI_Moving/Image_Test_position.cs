using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Image_Test_position : MonoBehaviour {

	public Image[] image;

	void Start () {
		for (int i=0; i<image.Length;i++) {
			Debug.Log ("image[" + i + "]" + image [i].transform.position);
		}
	}
	void Update () {
		
	}
}
