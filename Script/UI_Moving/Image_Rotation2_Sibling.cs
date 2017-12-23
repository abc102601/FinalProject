using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Image_Rotation2_Sibling: MonoBehaviour {

	static public int image0=4; 
	static public int image1=3; 
	static public int image2=1; 
	static public int image3=0; 
	static public int image4=2; 
	static public bool image0_ = true; //圖層是否最前判斷用;最前為true
	static public bool image1_ = false;
	static public bool image2_ = false;
	static public bool image3_ = false;
	static public bool image4_ = false;
	public Image _image0; 
	public Image _image1; 
	public Image _image2; 
	public Image _image3; 
	public Image _image4; 
	public Button _Clockwise_buttom;
	public Button _Counterclockwise_buttom;
	static public int position_count=0;
	static public int scale_count=0;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Image_Rotation2.position_output == true) //圖層切換接收 來源圖旋轉2(Image_Rotation2)
		{
			if(Image_Rotation2.slinbming_count==-2) //圖旋轉2計數器
			{
				_image2.transform.SetSiblingIndex (4);
				image2 = 4;
				_image3.transform.SetSiblingIndex (3);
				image3 = 3;
				_image4.transform.SetSiblingIndex (1);
				image4 = 1;
				if (Image_Rotation2.Counterclockwise_mode == true) //逆轉判斷式
				{
					
				} else {
					_image1.transform.SetSiblingIndex (2);
					image1 = 2;
				}
				if (Image_Rotation2.Counterclockwise_mode == true) //逆轉判斷式
				{
					Image_Rotation2.Counterclockwise_mode = false;
				} else {
					_image0.transform.SetSiblingIndex (0);
					image0 = 0;
				}

				image0_=false;
				image1_=false;
				image2_=true;
				image3_=false;
				image4_=false;
				Image_Rotation2.position_output = false;
//				Image_Effect1.start_image_find = true;
			}
			if(Image_Rotation2.slinbming_count==-1)
			{
				_image1.transform.SetSiblingIndex (4);
				image1 = 4;
				_image2.transform.SetSiblingIndex (3);
				image2 = 3;
				_image3.transform.SetSiblingIndex (1);
				image3 = 1;
				if (Image_Rotation2.Counterclockwise_mode == true) //逆轉判斷式
				{
					
				} else {
					_image0.transform.SetSiblingIndex (2);
					image0 = 2;
				}
				if (Image_Rotation2.Counterclockwise_mode == true) //逆轉判斷式
				{
					Image_Rotation2.Counterclockwise_mode = false;
				} else {
					_image4.transform.SetSiblingIndex (0);
					image4 = 0;
				}
				image0_=false;
				image1_=true;
				image2_=false;
				image3_=false;
				image4_=false;
				Image_Rotation2.position_output = false;
//				Image_Effect1.start_image_find = true;
			}
			if(Image_Rotation2.slinbming_count==0)
			{
				_image0.transform.SetSiblingIndex (4);
				image0 = 4;
				_image1.transform.SetSiblingIndex (3);
				image1 = 3;
				_image2.transform.SetSiblingIndex (1);
				image2 = 1;
				if (Image_Rotation2.Counterclockwise_mode == true) //逆轉判斷式
				{
					
				} else {
					_image4.transform.SetSiblingIndex (2);
					image4 = 2;
				}
				if (Image_Rotation2.Counterclockwise_mode == true) //逆轉判斷式
				{
					Image_Rotation2.Counterclockwise_mode = false;
				} else {
					_image3.transform.SetSiblingIndex (0);
					image3 = 0;
				}
				image0_=true;
				image1_=false;
				image2_=false;
				image3_=false;
				image4_=false;
				Image_Rotation2.position_output = false;
//				Image_Effect1.start_image_find = true;
			}
			if(Image_Rotation2.slinbming_count==1)
			{
				_image0.transform.SetSiblingIndex (3);
				image0 = 3;
				_image1.transform.SetSiblingIndex (1);
				image1 = 1;
				_image4.transform.SetSiblingIndex (4);
				image4 = 4;
				image0_=false;
				image1_=false;
				image2_=false;
				image3_=false;
				image4_=true;
				if (Image_Rotation2.Counterclockwise_mode == true) //逆轉判斷式
				{
					
				} else {
					_image3.transform.SetSiblingIndex (2);
					image3 = 2;
				}
				if (Image_Rotation2.Counterclockwise_mode == true) //逆轉判斷式
				{
					Image_Rotation2.Counterclockwise_mode = false;
				} else {
					_image2.transform.SetSiblingIndex (0);
					image2 = 0;
				}
				image0_=false;
				image1_=false;
				image2_=false;
				image3_=false;
				image4_=true;
				Image_Rotation2.position_output = false;
//				Image_Effect1.start_image_find = true;
			}
			if(Image_Rotation2.slinbming_count==2)
			{
				_image0.transform.SetSiblingIndex (1);
				image0 = 1;
				_image3.transform.SetSiblingIndex (4);
				image3 = 4;
				_image4.transform.SetSiblingIndex (3);
				image4 = 3;
				image0_=false;
				image1_=false;
				image2_=false;
				image3_=true;
				image4_=false;
				if (Image_Rotation2.Counterclockwise_mode == true) //逆轉判斷式
				{
					
				} else {
					_image1.transform.SetSiblingIndex (0);
					image1 = 0;
				}
				if (Image_Rotation2.Counterclockwise_mode == true) //逆轉判斷式
				{
					Image_Rotation2.Counterclockwise_mode = false;
				} else {
					_image2.transform.SetSiblingIndex (2);
					image2 = 2;
				}
				image0_=false;
				image1_=false;
				image2_=false;
				image3_=true;
				image4_=false;
				Image_Rotation2.position_output = false;
//				Image_Effect1.start_image_find = true;
			}
		}
	}
}

//_image0.transform.SetSiblingIndex ();
//_image1.transform.SetSiblingIndex ();
//_image2.transform.SetSiblingIndex ();
//_image3.transform.SetSiblingIndex ();
//_image4.transform.SetSiblingIndex ();
//Image_Rotation2.position_output = false;