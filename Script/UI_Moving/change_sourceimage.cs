using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class change_sourceimage : MonoBehaviour {

	public Image _image0;
	public Image _image1;
	public Image _image2;
	public Image _image3;
	public Image _image4;
	public Sprite oldtext0;
	public Sprite newtext0;
	public Sprite oldtext1;
	public Sprite newtext1;
	public Sprite oldtext2;
	public Sprite newtext2;
	public Sprite oldtext3;
	public Sprite newtext3;
	public Sprite oldtext4;
	public Sprite newtext4;
	int count=1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void change()
	{
		if (count == 1) {
			_image1.sprite = newtext1;
			}
		 else if (count == 2) {
		_image2.sprite = newtext2;


		} else if (count == 3) {
			_image3.sprite = newtext3;

		} else if (count == 4) {
			_image4.sprite = newtext4;
			}


		count++;
	}
}
