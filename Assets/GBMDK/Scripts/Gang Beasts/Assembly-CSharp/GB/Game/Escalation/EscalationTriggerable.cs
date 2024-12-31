using UnityEngine;

namespace GB.Game.Escalation
{
	[AddComponentMenu(null)]
	public abstract class EscalationTriggerable : EscalationBase
	{
		public static string GetDisplayName<T>() where T : EscalationTriggerable
		{
			return null;
		}
	}
}
