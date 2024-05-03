using UnityEngine;

namespace GB.Game.Escalation
{
	[AddComponentMenu(null)]
	public abstract class EscalationTimeTriggerBase : EscalationTriggerable
	{
		protected float _escalationTimePercentComplete;

		protected override void OnInitialize()
		{
		}

		public override void OnUpdate()
		{
		}
	}
}
