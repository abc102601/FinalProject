using System;
using UnityEngine;

namespace MonsterGenerator
{
	public interface IMonsterGenerator
	{
		float getTimeWait();
		GameObject getMonster();
	}
}

