using System.Collections.Generic;
using CoreNet.StateSync.BDSM;
using CoreNet.StateSync.Syncs;
using UnityEngine;

namespace GB.Networking.StateSync.Syncs
{
	[RequireComponent(typeof(Rigidbody))]
	public class DominantRigidbodySync : RigidbodySync, IDominant
	{
		private Dictionary<SubmissiveRigidbody, Vector3> _SubmissiveOffsets;

		private ActorCostume _Costume;

		private bool _SubmissivesLoaded;

		public override void SetSyncing(bool syncing, bool isServer)
		{
		}

		public Demand Supplicate(SubmissiveRigidbody sub)
		{
			return null;
		}

		public void OnDrawGizmosSelected()
		{
		}
	}
}
