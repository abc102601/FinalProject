using System;
using UnityEngine;

namespace MonsterGenerator
{
	public class CommonGenerator : IMonsterGenerator
	{
		public float timeWait;
		public GameObject monster;


		public CommonGenerator (float time, GameObject obj)
		{
			timeWait = time;
			monster = obj;
		}


		public float getTimeWait() {
			return timeWait;
		}

		public GameObject getMonster() {
			return monster;
		}


	}
}

