using UnityEngine;

namespace GB.Game.Escalation
{
	[AddComponentMenu(null)]
	public class EscalationTimeTrigger : EscalationTimeTriggerBase
	{
		[Tooltip("The round time completed in percent that this trigger will invoke on.")]
		public float triggerOnPercent;

		public new static string GetDisplayName<T>()
		{
			return null;
		}

		protected override bool CanActivate()
		{
			return false;
		}
	}
}
