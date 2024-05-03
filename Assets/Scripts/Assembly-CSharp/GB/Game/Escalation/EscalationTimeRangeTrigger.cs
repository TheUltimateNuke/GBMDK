using UnityEngine;

namespace GB.Game.Escalation
{
	[AddComponentMenu(null)]
	public class EscalationTimeRangeTrigger : EscalationTimeTriggerBase
	{
		[Tooltip("Percentage that must be complete before this trigger could potentially invoke.")]
		public float triggerOnPercentMin;

		[Tooltip("Percentage that this trigger will definately invoke on after reaching.")]
		public float triggerOnPercentMax;

		[Tooltip("Percent chance that the trigger will invoke before reaching triggerOnPercentMax")]
		public float triggerEarlyPercentChance;

		private float _activationChance;

		private float _activationOnRandomPercent;

		public new static string GetDisplayName<T>()
		{
			return null;
		}

		protected override void OnInitialize()
		{
		}

		protected override bool CanActivate()
		{
			return false;
		}

		public override void OnUpdate()
		{
		}
	}
}
