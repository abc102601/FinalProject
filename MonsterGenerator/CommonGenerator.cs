using System;
using UnityEngine;

namespace MonsterGenerator
{
	public class CommonGenerator : IMonsterGenerator
	{
		private float timeWait;
		private GameObject monster;

		public CommonGenerator (float time, GameObject obj)
		{
			timeWait = time;
			monster = obj;
		}

		float getTimeWait() {
			return timeWait;
		}

		GameObject getMonster() {
			return monster;
		}
	}
}

