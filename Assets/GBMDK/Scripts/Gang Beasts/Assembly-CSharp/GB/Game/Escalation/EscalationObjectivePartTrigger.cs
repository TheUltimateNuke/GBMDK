using GB.Game.Objective;
using GB.Networking.Objects;
using UnityEngine;

namespace GB.Game.Escalation
{
	[AddComponentMenu(null)]
	public abstract class EscalationObjectivePartTrigger : EscalationTriggerable
	{
		private bool _objectivePartAchieved;

		public bool IsObjectiveComplete => false;

		protected T AssignObjective<T>() where T : ObjectivePart
		{
			return null;
		}

		private bool ObjectivePartAchieved(NetBeast beast, ObjectivePart obj)
		{
			return false;
		}

		protected sealed override bool CanActivate()
		{
			return false;
		}

		protected virtual bool OnAchievedConditions()
		{
			return false;
		}
	}
}
