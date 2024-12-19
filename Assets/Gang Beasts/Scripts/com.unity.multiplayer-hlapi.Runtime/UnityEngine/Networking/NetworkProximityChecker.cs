using System;
using System.Collections.Generic;

namespace UnityEngine.Networking
{
	[AddComponentMenu("Network/NetworkProximityChecker")]
	[RequireComponent(typeof(NetworkIdentity))]
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	public class NetworkProximityChecker : NetworkBehaviour
	{
		public enum CheckMethod
		{
			Physics3D = 0,
			Physics2D = 1
		}

		[Tooltip("The maximum range that objects will be visible at.")]
		public int visRange;

		[Tooltip("How often (in seconds) that this object should update the set of players that can see it.")]
		public float visUpdateInterval;

		[Tooltip("Which method to use for checking proximity of players.\n\nPhysics3D uses 3D physics to determine proximity.\n\nPhysics2D uses 2D physics to determine proximity.")]
		public CheckMethod checkMethod;

		[Tooltip("Enable to force this object to be hidden from players.")]
		public bool forceHidden;

		private float m_VisUpdateTime;

		private void Update()
		{
		}

		public override bool OnCheckObserver(NetworkConnection newObserver)
		{
			return false;
		}

		public override bool OnRebuildObservers(HashSet<NetworkConnection> observers, bool initial)
		{
			return false;
		}

		public override void OnSetLocalVisibility(bool vis)
		{
		}

		private static void SetVis(GameObject go, bool vis)
		{
		}
	}
}
