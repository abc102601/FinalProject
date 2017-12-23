using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class background_change : MonoBehaviour {

	public Image background;
	public Sprite oldbackground;
	public Sprite newbackground;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void _change()
	{
		background.sprite = newbackground;
	}
	public void _return()
	{
		background.sprite = oldbackground;
	}

}
