using UnityEngine;
using UnityEngine.Networking;

namespace CoreNet.Objects
{
	public abstract class NetPlayer : NetConnectionAssociation
	{
		public enum PlayerType
		{
			Player = 0,
			AI = 1
		}

		public int ControllerId;

		public NetworkInstanceId IdentityId;

		public bool Alive;

		public bool GameOver;

		public PlayerType playerType;

		public GameObject Instance;

		public NetPlayer()
		{
		}

		public NetPlayer(int controllerId)
		{
		}

		public override void Serialize(NetworkWriter writer)
		{
		}

		public override void Deserialize(NetworkReader reader)
		{
		}
	}
}
