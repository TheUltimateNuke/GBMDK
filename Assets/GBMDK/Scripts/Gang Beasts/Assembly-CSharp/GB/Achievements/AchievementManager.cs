using Femur;
using UnityEngine;

namespace GB.Achievements
{
	public abstract class AchievementManager : MonoBehaviour
	{
		public abstract void AddPostCondition(PostCondition cond);

		public abstract void CheckAllConditionsComplete(AchievementCondition lastTrigger, Actor triggeringBeast);
	}
}
