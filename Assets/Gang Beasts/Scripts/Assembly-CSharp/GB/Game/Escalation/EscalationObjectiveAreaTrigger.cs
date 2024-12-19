using System.Collections.Generic;
using UnityEngine;

namespace GB.Game.Escalation
{
	[AddComponentMenu(null)]
	public class EscalationObjectiveAreaTrigger : EscalationObjectivePartTrigger
	{
		public float areaStayTime;

		public int minNumberOfBeastsToTrigger;

		public GameObject[] objectsInAreaToTrigger;

		private List<GameObject> objectsInArea;

		public new static string GetDisplayName<T>()
		{
			return null;
		}

		protected override void OnInitialize()
		{
		}

		protected override bool OnAchievedConditions()
		{
			return false;
		}

		public void OnTriggerEnter(Collider other)
		{
		}

		public void OnTriggerExit(Collider other)
		{
		}
	}
}
