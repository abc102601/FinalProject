using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Image_Rotation2 : MonoBehaviour {
	//記次值參數
	int position_count=0;
	int scale_count=0;
	//圖層判定參數
	static public bool position_output;
	static public int slinbming_count=0;
	static public bool Counterclockwise_mode;//逆轉模式
	static public bool Counterclockwise_mode2;//逆轉模式2次輸出
	//迴圈完成判別bool參數
	bool position_return;
	bool scale_return;
	//判斷式
	bool Clockwise=true;
	bool Counterclockwise=true;
	//外部套件
	public Image _image0; 
	public Image _image1; 
	public Image _image2; 
	public Image _image3; 
	public Image _image4; 
	public Button _Clockwise_buttom;
	public Button _Counterclockwise_buttom;
	//起始座標參數
	public Vector3 _position0 = new Vector3 (556, 402, 0);
	public Vector3 _position1 = new Vector3 (227, 510, 0);
	public Vector3 _position2 = new Vector3 (421, 575, 0);
	public Vector3 _position3 = new Vector3 (681, 575, 0);
	public Vector3 _position4 = new Vector3 (882, 510, 0);
	public Vector2 scale0 = new Vector3 (2, 2, 2);
	public Vector2 scale1 = new Vector3 (1.5f, 1.5f, 1.5f);
	public Vector2 scale2 = new Vector3 (1, 1, 1);
	public Vector2 scale3 = new Vector3 (1, 1, 1);
	public Vector2 scale4 = new Vector3 (1.5f, 1.5f, 1.5f);
    //順時針轉參數
	Vector2 distance_0to1;
	Vector2 distance_1to2;
	Vector2 distance_2to3;
	Vector2 distance_3to4;
	Vector2 distance_4to0;
	Vector2 value_0to1;
	Vector2 value_1to2;
	Vector2 value_2to3;
	Vector2 value_3to4;
	Vector2 value_4to0;
	//逆時針轉參數
	Vector2 distance_0to4;
	Vector2 distance_1to0;
	Vector2 distance_2to1;
	Vector2 distance_3to2;
	Vector2 distance_4to3;
	Vector2 value_0to4;
	Vector2 value_1to0;
	Vector2 value_2to1;
	Vector2 value_3to2;
	Vector2 value_4to3;




	void Start () {
		//初始化座標縮放
		_image0.transform.position = _position0;
		_image1.transform.position = _position1;
		_image2.transform.position = _position2;
		_image3.transform.position = _position3;
		_image4.transform.position = _position4;
		_image0.transform.localScale = scale0;
		_image1.transform.localScale = scale1;
		_image2.transform.localScale = scale2;
		_image3.transform.localScale = scale3;
		_image4.transform.localScale = scale4;

	
	}
	

	void Update () {
		
		if (position_return == true && scale_return == true) //迴圈完成回傳
		{
			_Clockwise_buttom.GetComponent<Button> ().enabled = true;//再次開啟觸發
			_Counterclockwise_buttom.GetComponent<Button> ().enabled = true;//再次開啟觸發
			position_return = false;//素質重置
			scale_return = false;//素質重置
		}
		if((Image_Rotation2_Sibling.image0 == 1 && 0<=position_count && position_count<=10)||(Image_Rotation2_Sibling.image0 == 0 && 10<=position_count && position_count<=20))
		{
			Clockwise=false;
		}
		else
		{
			Clockwise=true;
		}
		if ((Image_Rotation2_Sibling.image0 == 0 && 0<=position_count && position_count<=10)||(Image_Rotation2_Sibling.image0 == 1 && 10<=position_count && position_count<=20))
		{
			Counterclockwise=false;
		}
		else
		{
			Counterclockwise=true;
		}

	}
	public void Clockwise_click()
	{
		_Clockwise_buttom.GetComponent<Button> ().enabled = false;//關閉再次觸發
		_Counterclockwise_buttom.GetComponent<Button> ().enabled = false;//關閉再次觸發
		Counterclockwise_mode = false;//逆轉模式關閉
		slinbming_count+=1;//旋轉計數器+1
		if(slinbming_count==3)//旋轉計數器重整
		{
			slinbming_count = -2;
		}
		if(slinbming_count==-3)
		{
			slinbming_count = 2;
		}
		position_Clockwise ();//開啟移動函式迴圈
		scale_Clockwise ();//開啟縮放函式迴圈
	}

	public void Counterclockwise_click()
	{
		_Clockwise_buttom.GetComponent<Button> ().enabled = false;//關閉再次觸發
		_Counterclockwise_buttom.GetComponent<Button> ().enabled = false;//關閉再次觸發
		Counterclockwise_mode = true;//逆轉模式開啟
		slinbming_count-=1;//旋轉計數器-1
		if(slinbming_count==3)//旋轉計數器重整
		{
			slinbming_count = -2;
		}
		if(slinbming_count==-3)
		{
			slinbming_count = 2;
		}
		position_CounterClockwise ();//開啟移動函式迴圈
		scale_CounterClockwise ();//開啟縮放函式迴圈
	}
		

	//取得距離值/20並啟用移動函式
	void position_Clockwise()
	{
		distance_0to1.x = (_image1.transform.position.x - _position0.x) / 20;
		distance_0to1.y = (_image1.transform.position.y - _position0.y) / 20;
		distance_1to2.x = (_image2.transform.position.x - _position1.x) / 20;
		distance_1to2.y = (_image2.transform.position.y - _position1.y) / 20;
		distance_2to3.x = (_image3.transform.position.x - _position2.x) / 20;
		distance_2to3.y = (_image3.transform.position.y - _position2.y) / 20;
		distance_3to4.x = (_image4.transform.position.x - _position3.x) / 20;
		distance_3to4.y = (_image4.transform.position.y - _position3.y) / 20;
		distance_4to0.x = (_image0.transform.position.x - _position4.x) / 20;
		distance_4to0.y = (_image0.transform.position.y - _position4.y) / 20;
		InvokeRepeating("position_change_Clockwise",0.025f,0.025f);

	}
	//移動迴圈函示(外加position_count判定)
	void position_change_Clockwise()
	{
		position_count += 1;
		if (position_count == 10)
		{
			position_output=true;
		}
		if (position_count == 20) //20次一輪 計數器歸0
		{
			position_count = 0;//count歸0
			_image0.transform.position = _position1;//校正座標
			_image1.transform.position = _position2;
			_image2.transform.position = _position3;
			_image3.transform.position = _position4;
			_image4.transform.position = _position0;
			update_position ();//更新座標
			position_return=true;//回傳更改位置執行完畢
			CancelInvoke ("position_change_Clockwise");//停止迴圈運作
		}
		_image0.transform.position += new Vector3 (distance_0to1.x, distance_0to1.y, 0f);
		_image1.transform.position += new Vector3 (distance_1to2.x, distance_1to2.y, 0f);
		_image2.transform.position += new Vector3 (distance_2to3.x, distance_2to3.y, 0f);
		_image3.transform.position += new Vector3 (distance_3to4.x, distance_3to4.y, 0f);
		_image4.transform.position += new Vector3 (distance_4to0.x, distance_4to0.y, 0f);

	
	}

	//取得縮放差/20並啟用縮放函式
	void scale_Clockwise()
	{
		value_0to1.x = (_image1.transform.localScale.x - scale0.x) / 20;
		value_0to1.y = (_image1.transform.localScale.y - scale0.y) / 20;
		value_1to2.x = (_image2.transform.localScale.x - scale1.x) / 20;
		value_1to2.y = (_image2.transform.localScale.y - scale1.y) / 20;
		value_2to3.x = (_image3.transform.localScale.x - scale2.x) / 20;
		value_2to3.y = (_image3.transform.localScale.y - scale2.y) / 20;
		value_3to4.x = (_image4.transform.localScale.x - scale3.x) / 20;
		value_3to4.y = (_image4.transform.localScale.y - scale3.y) / 20;
		value_4to0.x = (_image0.transform.localScale.x - scale4.x) / 20;
		value_4to0.y = (_image0.transform.localScale.y - scale4.y) / 20;
		InvokeRepeating ("scale_change_Clockwise",0.025f,0.025f);
	}
	//縮放迴圈函式(外加scale_count判定)
	void scale_change_Clockwise()
	{
		scale_count += 1;
		if (scale_count == 20) {
			scale_count = 0;//count歸0
			_image0.transform.localScale = scale1;//校正縮放值
			_image1.transform.localScale = scale2;
			_image2.transform.localScale = scale3;
			_image3.transform.localScale = scale4;
			_image4.transform.localScale = scale0;
			update_scale ();//更新縮放值
			scale_return=true;//回傳縮放更改執行完畢
			CancelInvoke ("scale_change_Clockwise");//停止迴圈運作

		}
		_image0.transform.localScale += new Vector3 (value_0to1.x, value_0to1.y, 0f);
		_image1.transform.localScale += new Vector3 (value_1to2.x, value_1to2.y, 0f);
		_image2.transform.localScale += new Vector3 (value_2to3.x, value_2to3.y, 0f);
		_image3.transform.localScale += new Vector3 (value_3to4.x, value_3to4.y, 0f);
		_image4.transform.localScale += new Vector3 (value_4to0.x, value_4to0.y, 0f);
	

	}



///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




	//取得距離值/20並啟用移動函式
	void position_CounterClockwise()
	{
		distance_0to4.x = (_image4.transform.position.x - _position0.x) / 20;
		distance_0to4.y = (_image4.transform.position.y - _position0.y) / 20;
		distance_1to0.x = (_image0.transform.position.x - _position1.x) / 20;
		distance_1to0.y = (_image0.transform.position.y - _position1.y) / 20;
		distance_2to1.x = (_image1.transform.position.x - _position2.x) / 20;
		distance_2to1.y = (_image1.transform.position.y - _position2.y) / 20;
		distance_3to2.x = (_image2.transform.position.x - _position3.x) / 20;
		distance_3to2.y = (_image2.transform.position.y - _position3.y) / 20;
		distance_4to3.x = (_image3.transform.position.x - _position4.x) / 20;
		distance_4to3.y = (_image3.transform.position.y - _position4.y) / 20;
		InvokeRepeating("position_change_CounterClockwise",0.025f,0.025f);

	}
	//移動迴圈函示(外加position_count判定)
	void position_change_CounterClockwise()
	{
		position_count += 1;
		if (position_count == 10)
		{
			position_output=true;
		}
		if (position_count == 20) {
			Counterclockwise_mode2 = true;//逆轉判斷是二次輸出
			position_count = 0;//count歸0
			_image0.transform.position = _position4;//校正座標
			_image1.transform.position = _position0;
			_image2.transform.position = _position1;
			_image3.transform.position = _position2;
			_image4.transform.position = _position3;
			update_position ();//更新座標
			position_return=true;//回傳更改位置執行完畢
			CancelInvoke ("position_change_CounterClockwise");//停止迴圈運作
		}

			_image0.transform.position += new Vector3 (distance_0to4.x, distance_0to4.y, 0f);
			_image1.transform.position += new Vector3 (distance_1to0.x, distance_1to0.y, 0f);
			_image2.transform.position += new Vector3 (distance_2to1.x, distance_2to1.y, 0f);
			_image3.transform.position += new Vector3 (distance_3to2.x, distance_3to2.y, 0f);
			_image4.transform.position += new Vector3 (distance_4to3.x, distance_4to3.y, 0f);
		
	}

	//取得縮放差/20並啟用縮放函式
	void scale_CounterClockwise()
	{
		value_0to4.x = (_image4.transform.localScale.x - scale0.x) / 20;
		value_0to4.y = (_image4.transform.localScale.y - scale0.y) / 20;
		value_1to0.x = (_image0.transform.localScale.x - scale1.x) / 20;
		value_1to0.y = (_image0.transform.localScale.y - scale1.y) / 20;
		value_2to1.x = (_image1.transform.localScale.x - scale2.x) / 20;
		value_2to1.y = (_image1.transform.localScale.y - scale2.y) / 20;
		value_3to2.x = (_image2.transform.localScale.x - scale3.x) / 20;
		value_3to2.y = (_image2.transform.localScale.y - scale3.y) / 20;
		value_4to3.x = (_image3.transform.localScale.x - scale4.x) / 20;
		value_4to3.y = (_image3.transform.localScale.y - scale4.y) / 20;
		InvokeRepeating ("scale_change_CounterClockwise",0.025f,0.025f);
	}
	//縮放迴圈函式(外加scale_count判定)
	void scale_change_CounterClockwise()
	{
		scale_count += 1;
		if (scale_count == 20) {
			scale_count = 0;//count歸0
			_image0.transform.localScale = scale4;//校正縮放值
			_image1.transform.localScale = scale0;
			_image2.transform.localScale = scale1;
			_image3.transform.localScale = scale2;
			_image4.transform.localScale = scale3;
			update_scale ();//更新縮放值
			scale_return=true;//回傳縮放更改執行完畢
			CancelInvoke ("scale_change_CounterClockwise");//停止迴圈運作

		}
		_image0.transform.localScale += new Vector3 (value_0to4.x, value_0to4.y, 0f);
		_image1.transform.localScale += new Vector3 (value_1to0.x, value_1to0.y, 0f);
		_image2.transform.localScale += new Vector3 (value_2to1.x, value_2to1.y, 0f);
		_image3.transform.localScale += new Vector3 (value_3to2.x, value_3to2.y, 0f);
		_image4.transform.localScale += new Vector3 (value_4to3.x, value_4to3.y, 0f);

	}
	//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	//更新移動座標函式
	void update_position()
	{
		_position0.x = _image0.transform.position.x;
		_position1.x = _image1.transform.position.x;
		_position2.x = _image2.transform.position.x;
		_position3.x = _image3.transform.position.x;
		_position4.x = _image4.transform.position.x;
		_position0.y = _image0.transform.position.y;
		_position1.y = _image1.transform.position.y;
		_position2.y = _image2.transform.position.y;
		_position3.y = _image3.transform.position.y;
		_position4.y = _image4.transform.position.y;
	}

	//更新縮放值函式
	void update_scale()
	{
		scale0.x = _image0.transform.localScale.x;
		scale1.x = _image1.transform.localScale.x;
		scale2.x = _image2.transform.localScale.x;
		scale3.x = _image3.transform.localScale.x;
		scale4.x = _image4.transform.localScale.x;
		scale0.y = _image0.transform.localScale.y;
		scale1.y = _image1.transform.localScale.y;
		scale2.y = _image2.transform.localScale.y;
		scale3.y = _image3.transform.localScale.y;
		scale4.y = _image4.transform.localScale.y;
	}




}
