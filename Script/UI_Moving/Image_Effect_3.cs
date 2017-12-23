using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Image_Effect_3: MonoBehaviour {
	public Image image3; 
	Vector3 image3_vector3;
	Quaternion image3_quaternion;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void OnMouseEnter()
	{
		if (Image_Rotation2_Sibling.image3_ == true) //判斷是某為最前圖層
		{
			image3_vector3 = image3.transform.localScale;//儲存位置資訊
			image3_quaternion = image3.transform.rotation;
			image3.GetComponent<Animator> ().enabled = true;//啟動動畫
		}

	}

	public void OnMouseExit()
	{
		if (Image_Rotation2_Sibling.image3_ == true) //判斷是某為最前圖層
		{
			image3.GetComponent<Animator> ().enabled = false;//關閉動畫
			image3.transform.localScale = image3_vector3;//回歸位置資訊
			image3.transform.rotation = image3_quaternion;
		}

	}




}
