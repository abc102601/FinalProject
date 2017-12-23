using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Image_Effect_1 : MonoBehaviour {
	public Image image1; 
	Vector3 image1_vector3;
	Quaternion image1_quaternion;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void OnMouseEnter()
	{
		if (Image_Rotation2_Sibling.image1_ == true) //判斷是某為最前圖層
		{
			image1_vector3 = image1.transform.localScale;//儲存位置資訊
			image1_quaternion = image1.transform.rotation;
			image1.GetComponent<Animator> ().enabled = true;//啟動動畫
		}

	}

	public void OnMouseExit()
	{
		if (Image_Rotation2_Sibling.image1_ == true) //判斷是某為最前圖層
		{
			image1.GetComponent<Animator> ().enabled = false;//關閉動畫
			image1.transform.localScale = image1_vector3;//回歸位置資訊
			image1.transform.rotation = image1_quaternion;
		}

	}




}
