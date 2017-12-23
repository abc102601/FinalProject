using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;


public class find_image : MonoBehaviour {
//
//	int count=0;
//	Transform count_transform; 
//	public Image _image0; 
//	public Image _image1; 
//	public Image _image2; 
//	public Image _image3; 
//	public Image _image4; 
//	static public bool MouseEnter1=false;
//	static public bool MouseEnter2=false;
//	static public bool MouseEnter3=false;
//	static public bool MouseEnter4=false;
//	static public bool MouseExit1=false;
//	static public bool MouseExit2=false;
//	static public bool MouseExit3=false;
//	static public bool MouseExit4=false;
//	public Vector3 Image_sway_Angel;
//	static public bool start_image_find;
//	bool count_break = false;//協程暫停判別式
//	bool count_IEnumerator = false;//協程結束判別式
//	Vector3 Initial_Image_sway_Angel;
	//		public int Image_sway_Angel_x;
	//		public int Image_sway_Angel_y;
	//		public int Image_sway_Angel_z;

	void Start () {
		//儲存初始選轉職
//		Initial_Image_sway_Angel=new Vector3(Initial_Image_sway_Angel.x,Initial_Image_sway_Angel.y,Initial_Image_sway_Angel.z);
		//重置x.y.z選轉值/20
//		Image_sway_Angel.x = Image_sway_Angel.x / 20;
//		Image_sway_Angel.y = Image_sway_Angel.y / 20;
//		Image_sway_Angel.z = Image_sway_Angel.z / 20;
//		//呼叫搜索最前圖層圖片並儲存函式
//		image0_find();

		//
	}



	void Update () {
//		if (start_image_find == true) //image_Rotation2的回傳值觸發重搜圖片
//		{
//			image0_find ();
//			start_image_find = false;
//		}
//		if (MouseEnter1 == true) {
//			Image_sway_enter ();
//			MouseEnter1 = false;
//		}
//		if (MouseEnter2 == true) {
//			Image_sway_enter ();
//			MouseEnter2 = false;
//		}
//		if (MouseEnter3 == true) {
//			Image_sway_enter ();
//			MouseEnter3 = false;
//		}
//		if (MouseEnter4 == true) {
//			Image_sway_enter ();
//			MouseEnter4 = false;
//		}
//		if (MouseExit1 == true) {
//			Image_sway_out ();
//			MouseExit1 = false;
//		}
//		if (MouseExit2 == true) {
//			Image_sway_out ();
//			MouseExit2 = false;
//		}
//		if (MouseExit3 == true) {
//			Image_sway_out ();
//			MouseExit3 = false;
//		}
//		if (MouseExit4 == true) {
//			Image_sway_out ();
//			MouseExit4 = false;
//		}

		//		Debug.Log (count_IEnumerator);

	}

//	public void Image_sway_enter()
//	{
//		if (count_break == true) //關閉協程暫停開關
//		{
//			count_break = false;
//		}
//		if (count_IEnumerator == false)//判定協程結束為關閉,後呼叫協程 
//		{
//			StartCoroutine ("Image_sway_enter_start");
//			Debug.Log ("成功呼叫函式");
//		} 
//		scale_big ();//放大
//	}

//	public void Image_sway_out()
//	{ 
//		Debug.Log ("Image_sway_out");
//		count_break = true;//開啟暫停協程開關
//		CancelInvoke ("down");//停止逆轉函式
//		CancelInvoke ("up");//停止順轉函式
//		count = 0;
////		scale_small ();//縮小
////		return_rotate ();//回歸初始旋轉值
//		image0_find();
//	}


//	IEnumerator Image_sway_enter_start()
//	{
//
//		count_IEnumerator = true;
//		for(var i=1;i==0||count_break==false;i++ )
//		{
//			count_IEnumerator = true;
//			if (count_break == false) {
//				yield return new WaitForSeconds (0.51f); 
//				Debug.Log ("waittime1");
//			}
//			if (count_break == false) {
//				InvokeRepeating("up",0.025f,0.025f);
//				Debug.Log ("up1_start");
//			}
//			if (count_break == false) {
//				yield return new WaitForSeconds (0.51f); 
//				Debug.Log ("waittime2");
//			}
//			if (count_break == false) {
//				InvokeRepeating("down",0.025f,0.025f);
//				Debug.Log ("down1_start");
//			}
//			if (count_break == false) {
//				yield return new WaitForSeconds (0.51f); 
//				Debug.Log ("waittime3");
//			}
//			if (count_break == false) {
//				InvokeRepeating("down",0.025f,0.025f);
//				Debug.Log ("down2_start");
//			}
//			if (count_break == false) {
//				yield return new WaitForSeconds (0.51f); 
//				Debug.Log ("waittime4");
//			}
//			if (count_break == false) {
//				InvokeRepeating("up",0.025f,0.025f);
//				Debug.Log ("up2_start");
//			}
//			count_IEnumerator = false;
//		}
//
//		Debug.Log ("協程結束");
//		yield break;
//
//	}
//	void scale_big()//放大函式
//	{
//		count_transform.transform.localScale += new Vector3 (0.3f,
//			0.3f,
//			0.3f);
//	}
//	void scale_small()//縮小函式
//	{
//		count_transform.transform.localScale -= new Vector3 (0.3f,
//			0.3f,
//			0.3f);
//	}

//	void up()//順旋轉函式
//	{
//
//		if(count==20)
//		{
//			count = 0;
//			CancelInvoke ("up");
//		}
//		count_transform.transform.Rotate (Image_sway_Angel.x
//			, Image_sway_Angel.y
//			, Image_sway_Angel.z);
//		count += 1;
//	}
//	void down()//逆旋轉函式
//	{
//
//		if(count==20)
//		{
//			count = 0;
//			CancelInvoke ("down");
//		}
//		count_transform.transform.Rotate (-Image_sway_Angel.x
//			, -Image_sway_Angel.y
//			, -Image_sway_Angel.z);
//		count += 1;
//	}
//
//	void image0_find()//搜索最前圖層圖片並儲存初始值
//	{
//
//
//		if (Image_Rotation2_Sibling.image0==4) {
//			count_transform = _image0.GetComponent<Transform>();
////			svae_rotate ();
//			Debug.Log ("Image_sway_enter:image0");
//		} else if (Image_Rotation2_Sibling.image1==4) {
//			count_transform = _image1.GetComponent<Transform>();
////			svae_rotate ();
//			Debug.Log ("Image_sway_enter:image1");
//		} else if (Image_Rotation2_Sibling.image2==4) {
//			count_transform = _image2.GetComponent<Transform>();
////			svae_rotate ();
//			Debug.Log ("Image_sway_enter:image2");
//		} else if (Image_Rotation2_Sibling.image3==4) {
//			count_transform = _image3.GetComponent<Transform>();
////			svae_rotate ();
//			Debug.Log ("Image_sway_enter:image3");
//		} else if (Image_Rotation2_Sibling.image4==4) {
//			count_transform = _image4.GetComponent<Transform>();
////			svae_rotate ();
//			Debug.Log ("Image_sway_enter:image4");
//		}
//	}

//	void release()//釋放資源
//	{
//		CancelInvoke ("down");
//		CancelInvoke ("up");
//		count = 0;
//		return_rotate ();
//	}
//
//	void svae_rotate()//儲存初始值
//	{
//		Initial_Image_sway_Angel=new Vector3(count_transform.transform.eulerAngles.x,count_transform.transform.eulerAngles.y,count_transform.transform.eulerAngles.z);
//		Debug.Log ("svae_rotate,當前旋轉值:" + Initial_Image_sway_Angel);
//	}
//
//	void return_rotate()//回歸旋轉值
//	{
//		count_transform.transform.eulerAngles = new Vector3 (Initial_Image_sway_Angel.x,Initial_Image_sway_Angel.y,Initial_Image_sway_Angel.z);
//	}

//	public void OnMouseEnter()
//	{
//		if (Image_Rotation2_Sibling.image0_ == true) 
//		{
//			_image0.GetComponent<Animator> ().enabled = true;
//		}
//
//	}
//
//	public void OnMouseExit()
//	{
//		if (Image_Rotation2_Sibling.image0_ == true) 
//		{
//			_image0.GetComponent<Animator> ().enabled = false;
//		}
//
//	}
//


}