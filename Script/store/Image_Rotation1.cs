using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Image_Rotation1 : MonoBehaviour {

	public Image ima1;
	public Image ima2;
	public Image ima3;
	public Image ima4;
	public Image ima5;
	public Sprite sp1_old;
	public Sprite sp2_old;
	public Sprite sp3_old;
	public Sprite sp4_old;
	public Sprite sp5_old;
	public Sprite sp1;
	public Sprite sp2;
	public Sprite sp3;
	public Sprite sp4;
	public Sprite sp5;
	private Transform tra1;
	private Sprite p_ima1;
	private Sprite p_ima2;
	private Sprite p_ima3;
	private Sprite p_ima4;
	private Sprite p_ima5;
	private int count=2; 
	private string count_string= "class2";





	// Use this for initialization
	void Start () {

		tra1 = GameObject.Find ("Image0").GetComponent<Transform> ();
		p_ima1 = GameObject.Find ("Image0").GetComponent<Image> ().sprite;
		p_ima2 = GameObject.Find ("Image1").GetComponent<Image> ().sprite;
		p_ima3 = GameObject.Find ("Image2").GetComponent<Image> ().sprite;
		p_ima4 = GameObject.Find ("Image3").GetComponent<Image> ().sprite;
		p_ima5 = GameObject.Find ("Image4").GetComponent<Image> ().sprite;


	}
	
	// Update is called once per frame
	void Update () {

	
	}

	public void buttom_down1()
	{
		

	}

	public void point_enter()
	{
		
//		tra1.localScale += new Vector3 (0.2f, 0.2f, 0.2f);

	}

	public void point_out()
	{
		
//		tra1.localScale -= new Vector3 (0.2f, 0.2f, 0.2f);

	}

	public void buttom_down2()
	{
		ima1.sprite = p_ima2;
		ima2.sprite = p_ima3;
		ima3.sprite = p_ima4;
		ima4.sprite = p_ima5;
		ima5.sprite = p_ima1;
		update_image ();

	}


	public void buttom_down3()
	{
		ima1.sprite = p_ima2;
		ima2.sprite = p_ima3;
		ima3.sprite = p_ima4;
		ima4.sprite = p_ima5;
		ima5.sprite = p_ima1;
		update_image ();

	}


	public void buttom_down4()
	{
		ima1.sprite = p_ima5;
		ima2.sprite = p_ima1;
		ima3.sprite = p_ima2;
		ima4.sprite = p_ima3;
		ima5.sprite = p_ima4;
		update_image ();

	}


	public void buttom_down5()
	{
		ima1.sprite = p_ima5;
		ima2.sprite = p_ima1;
		ima3.sprite = p_ima2;
		ima4.sprite = p_ima3;
		ima5.sprite = p_ima4;
		update_image ();

	}

	void update_image()
	{
		p_ima1 = GameObject.Find ("Image0").GetComponent<Image> ().sprite;
		p_ima2 = GameObject.Find ("Image1").GetComponent<Image> ().sprite;
		p_ima3 = GameObject.Find ("Image2").GetComponent<Image> ().sprite;
		p_ima4 = GameObject.Find ("Image3").GetComponent<Image> ().sprite;
		p_ima5 = GameObject.Find ("Image4").GetComponent<Image> ().sprite;
	}

	public void class_open()
	{
//		if (ima1.sprite == "class2") {
//			ima1.sprite = p_ima2;
//		} else if (ima2.sprite == "class2") {
//			ima2.sprite = p_ima2;
//		} else if (ima3.sprite == "class2") {
//			ima3.sprite = p_ima2;
//		} else if (ima4.sprite == "class2") {
//			ima4.sprite = p_ima2;
//		} else if (ima5.sprite == "class2") {
//			ima5.sprite = p_ima2;
//		}
		if (count == 2) {
			if (ima1.sprite == sp2_old) {
				ima1.sprite = sp2;
			} else if (ima2.sprite == sp2_old) {
				ima2.sprite = sp2;
			} else if (ima3.sprite == sp2_old) {
				ima3.sprite = sp2;
			} else if (ima4.sprite == sp2_old) {
				ima4.sprite = sp2;
			} else if (ima5.sprite == sp2_old) {
				ima5.sprite = sp2;
			}
		} else if (count == 3) {
			if (ima1.sprite == sp2_old) {
				ima1.sprite = sp3;
			} else if (ima2.sprite == sp3_old) {
				ima2.sprite = sp3;
			} else if (ima3.sprite == sp3_old) {
				ima3.sprite = sp3;
			} else if (ima4.sprite == sp3_old) {
				ima4.sprite = sp3;
			} else if (ima5.sprite == sp3_old) {
				ima5.sprite = sp3;
			}
		
		} else if (count == 4) {
					if (ima1.sprite == sp4_old) {
				ima1.sprite = sp4;
					} else if (ima2.sprite == sp4_old) {
				ima2.sprite = sp4;
					} else if (ima3.sprite == sp4_old) {
				ima3.sprite = sp4;
					} else if (ima4.sprite == sp4_old) {
				ima4.sprite = sp4;
					} else if (ima5.sprite == sp4_old) {
				ima5.sprite = sp4;
			}

		} else if (count == 5) {
					if (ima1.sprite == sp5_old) {
				ima1.sprite = sp5;
					} else if (ima2.sprite == sp5_old) {
				ima2.sprite = sp5;
					} else if (ima3.sprite == sp5_old) {
				ima3.sprite = sp5;
					} else if (ima4.sprite == sp5_old) {
				ima4.sprite = sp5;
					} else if (ima5.sprite == sp5_old) {
				ima5.sprite = sp5;
			}

		}
		count++;
		update_image ();
	}

	void update_class_open()
	{
		ima1.sprite = p_ima1;
		ima2.sprite = p_ima2;
		ima3.sprite = p_ima3;
		ima4.sprite = p_ima4;
		ima5.sprite = p_ima5;
		update_image ();

	}

}


