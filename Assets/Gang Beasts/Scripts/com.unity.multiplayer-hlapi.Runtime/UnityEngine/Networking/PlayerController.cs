using System;

namespace UnityEngine.Networking
{
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	public class PlayerController
	{
		internal const short kMaxLocalPlayers = 8;

		public short playerControllerId;

		public NetworkIdentity unetView;

		public GameObject gameObject;

		public const int MaxPlayersPerClient = 32;

		public bool IsValid => false;

		public PlayerController()
		{
		}

		internal PlayerController(GameObject go, short playerControllerId)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
