using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Image_Effect_2 : MonoBehaviour {
	public Image image2; 
	Vector3 image2_vector3;
	Quaternion image2_quaternion;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void OnMouseEnter()
	{
		if (Image_Rotation2_Sibling.image2_ == true) //判斷是某為最前圖層
		{
			image2_vector3 = image2.transform.localScale;//儲存位置資訊
			image2_quaternion = image2.transform.rotation;
			image2.GetComponent<Animator> ().enabled = true;//啟動動畫
		}

	}

	public void OnMouseExit()
	{
		if (Image_Rotation2_Sibling.image2_ == true) //判斷是某為最前圖層
		{
			image2.GetComponent<Animator> ().enabled = false;//關閉動畫
			image2.transform.localScale = image2_vector3;//回歸位置資訊
			image2.transform.rotation = image2_quaternion;
		}

	}




}
