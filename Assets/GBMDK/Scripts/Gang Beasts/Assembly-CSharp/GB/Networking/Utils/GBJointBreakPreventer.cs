using UnityEngine;

namespace GB.Networking.Utils
{
	public class GBJointBreakPreventer : MonoBehaviour
	{
		private struct JointValueCache
		{
			public float cachedForce;

			public float cachedTorque;
		}

		[SerializeField]
		private bool _preventEarlyBreak;

		[SerializeField]
		private Joint[] joints;

		private bool _invulnerable;

		private JointValueCache[] cachedJointValues;

		private void Awake()
		{
		}

		private void GameStarted()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
