using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Image_Right_In : MonoBehaviour {

	bool bbbb = true;
	public Image image;//主圖片
	public float image_width;
	public float image_height;
	public float image_scale_x;
	public float image_scale_y;
	public float speed=0;//移動速度
	public float frame_persecond;
	Vector3 position;//暫存位置
	float distance=0;//移動距離
	float time;//移動時間間隔
	// Use this for initialization

	void Start () {
		position = image.transform.position;
		image.transform.Translate (image_width * image_scale_x, 0, 0);//移出畫面待機進入視線
		distance = image_width * image_scale_x;//求得並儲存距離值(無正負方向)
		time = distance/speed;//求得時間
		if(time < 2f&&time > 0f)
		{
			Debug.Log ("來自" + image.ToString () + "的訊息,適中的速度,將進行" + Mathf.Ceil (time * frame_persecond) + "次移動");
			if (time == 0) {
				Debug.Log ("設定速度以確保");
			}
		}else{
			Debug.Log("來自" + image.ToString() + "的訊息,將進行" + Mathf.Ceil (time * frame_persecond) +"次移動");
			Debug.Log ("建議將速度調為" + distance / 1 + "pixel/s以減少遊戲負擔");
			bbbb = false;
		}
	}

	void Update () {
		
		if (bbbb == true) {
			move_void ();
			Debug.Log("呼叫總移動函式");
			bbbb = false;
		}
	}

	public void go()
	{
		move_void ();
		Debug.Log("呼叫總移動函式");
	}

	int count;//移動計數器
	void move_void ()//總移動函式
	{
		count = 0;
		InvokeRepeating ("move_count", time/frame_persecond, time/frame_persecond);//呼叫判斷式
		Debug.Log("呼叫移動計數器函式");
	}

	void move_count ()//移動計數器判斷用
	{
		count += 1;//計數器+1
		if (count > Mathf.Ceil (time * frame_persecond))   //做足呼叫次數終止呼叫
		{
			CancelInvoke ("move_void");//終止呼叫
			CancelInvoke ("move_count");//終止呼叫
			Debug.Log("判斷滿足次數");
			image.transform.position = position;//確保回歸座標
			count = 0;
		} else {                    //為滿足呼叫次數再次呼叫移動函式
			move ();
			Debug.Log("未滿足次數再次呼叫移動函式");
		}
	}
	void move ()//移動函式
	{
		image.transform.Translate (-distance / (time * frame_persecond), 0, 0);//每秒移動20次
		Debug.Log("移動");
	}


}