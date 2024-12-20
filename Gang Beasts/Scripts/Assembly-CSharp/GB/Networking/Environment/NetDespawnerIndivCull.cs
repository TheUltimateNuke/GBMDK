using System.Collections.Generic;
using UnityEngine;

namespace GB.Networking.Environment
{
	public class NetDespawnerIndivCull : MonoBehaviour
	{
		public bool _TriggeredElsewhere;

		[SerializeField]
		private List<DespawningChild> ChildrenToDespawn;

		private void Start()
		{
		}

		public void EvalDespawn()
		{
		}

		public void AddChild(GameObject child, float chance = 0.5f)
		{
		}

		public void OverwriteChildDespawnChance(float chance)
		{
		}

		public void ClearChildren()
		{
		}
	}
}
