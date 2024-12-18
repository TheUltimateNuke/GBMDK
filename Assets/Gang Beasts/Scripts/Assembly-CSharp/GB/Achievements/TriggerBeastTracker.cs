using Femur;

namespace GB.Achievements
{
	internal class TriggerBeastTracker
	{
		public Actor beastRef;

		public float lastTriggerTime;

		public bool achievementUnlocked;

		public TriggerBeastTracker(Actor beast, float startTime)
		{
		}
	}
}
