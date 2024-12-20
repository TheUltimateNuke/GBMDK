using System.Collections.Generic;
using UnityEngine;

namespace CoreNet.StateSync.BDSM
{
	[RequireComponent(typeof(Rigidbody))]
	public class DominantRigidbody : MonoBehaviour, IDominant
	{
		private Dictionary<SubmissiveRigidbody, Vector3> _SubmissiveOffsets;

		private bool _SubmissivesLoaded;

		public Demand Supplicate(SubmissiveRigidbody sub)
		{
			return null;
		}

		public void OnDrawGizmosSelected()
		{
		}
	}
}
