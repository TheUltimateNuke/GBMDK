using GB.Networking.Objects;
using UnityEngine;

namespace GB.Game.Objective
{
	public class Objective : ObjectivePart
	{
		public enum ObjectiveLevel
		{
			Solo = 0,
			Gang = 1,
			Game = 2,
			SoloTargeted = 3,
			GangTargeted = 4,
			GameTargeted = 5
		}

		[SerializeField]
		protected bool _active;

		[SerializeField]
		protected ObjectiveLevel _objectiveLevel;

		[SerializeField]
		protected ObjectivePart[] _objectives;

		protected CompleteTracker _tracker;

		[SerializeField]
		protected int _completeTarget;

		[SerializeField]
		protected bool _careOrder;

		[SerializeField]
		protected string _achievementOnComplete;

		public override bool Active => false;

		private static CompleteTracker GetCompleteTracker(ObjectiveLevel level)
		{
			return null;
		}

		public void SetActive(bool value)
		{
		}

		private void Awake()
		{
		}

		private bool ObjectiveUnlocked(NetBeast arg1, ObjectivePart arg2)
		{
			return false;
		}

		public virtual bool ObjectiveAchieved(NetBeast beast, ObjectivePart complete)
		{
			return false;
		}

		public virtual bool ObjectiveRetracted(NetBeast beast, ObjectivePart retract)
		{
			return false;
		}

		public virtual bool Completed(NetBeast beast)
		{
			return false;
		}
	}
}
