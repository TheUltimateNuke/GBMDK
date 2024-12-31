using System;
using UnityEngine;
using UnityEngine.Events;

namespace GB.Game.Escalation
{
	[Serializable]
	public class EscalationEvent : UnityEvent
	{
		[SerializeField]
		public string escalationClassTypeName;
	}
}
