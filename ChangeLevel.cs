using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLevel : MonoBehaviour {

	public float[] wait_time;
	public GameObject[] monster;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator monster_create()
	{
		for(int i=0;i<=wait_time.Length-1;i++)
		{
			yield return new WaitForSeconds (wait_time[i]);
			Instantiate (monster [i], new Vector3 (0, 0, 0), transform.rotation);
		}


	}
	public void onCreateMonsterClick()
	{
		StartCoroutine ("monster_create");

	}
}
