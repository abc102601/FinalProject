using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Image_Effect_0 : MonoBehaviour {
	public Image image0; 
	Vector3 image0_vector3;
	Quaternion image0_quaternion;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void OnMouseEnter()
	{
		if (Image_Rotation2_Sibling.image0_ == true) //判斷是某為最前圖層
		{
			image0_vector3 = image0.transform.localScale;//儲存位置資訊
			image0_quaternion = image0.transform.rotation;
			image0.GetComponent<Animator> ().enabled = true;//啟動動畫
		}

	}

	public void OnMouseExit()
	{
		if (Image_Rotation2_Sibling.image0_ == true) //判斷是某為最前圖層
		{
			image0.GetComponent<Animator> ().enabled = false;//關閉動畫
			image0.transform.localScale = image0_vector3;//回歸位置資訊
			image0.transform.rotation = image0_quaternion;
		}

	}




}
