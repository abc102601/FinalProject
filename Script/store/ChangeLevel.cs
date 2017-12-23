using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MonsterGenerator;

public class ChangeLevel : MonoBehaviour {

	public float[] wait_time;
	public GameObject[] monster;
	public GameObject obj1;
	public GameObject obj2;
	public Vector3[] cahge;
	public IMonsterGenerator a;
	public CanvasGroup[] els;
//	public List<IMonsterGenerator> generators;
//	float a;

	// Use this for initialization
	public ChangeLevel () {
		
	}


	void Start () {
		

//		obj1 = GameObject.Find ("Monster01");
		IMonsterGenerator gen1 = new CommonGenerator (1.5f, obj1);
		Destroy (gen1.getMonster(),gen1.getTimeWait());



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
