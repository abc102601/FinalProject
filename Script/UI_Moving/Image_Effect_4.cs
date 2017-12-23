using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Image_Effect_4 : MonoBehaviour {
	public Image image4; 
	Vector3 image4_vector3;
	Quaternion image4_quaternion;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void OnMouseEnter()
	{
		if (Image_Rotation2_Sibling.image4_ == true) //判斷是某為最前圖層
		{
			image4_vector3 = image4.transform.localScale;//儲存位置資訊
			image4_quaternion = image4.transform.rotation;
			image4.GetComponent<Animator> ().enabled = true;//啟動動畫
		}

	}

	public void OnMouseExit()
	{
		if (Image_Rotation2_Sibling.image4_ == true) //判斷是某為最前圖層
		{
			image4.GetComponent<Animator> ().enabled = false;//關閉動畫
			image4.transform.localScale = image4_vector3;//回歸位置資訊
			image4.transform.rotation = image4_quaternion;
		}

	}




}
