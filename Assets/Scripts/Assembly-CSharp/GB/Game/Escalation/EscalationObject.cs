using System.Collections.Generic;
using UnityEngine;

namespace GB.Game.Escalation
{
	[DisallowMultipleComponent]
	public class EscalationObject : MonoBehaviour
	{
		[SerializeField]
		public List<EscalationEvent> onActives;

		[SerializeField]
		public EscalationType escalationType;

		[SerializeField]
		public string friendlyEscalationName;
	}
}
