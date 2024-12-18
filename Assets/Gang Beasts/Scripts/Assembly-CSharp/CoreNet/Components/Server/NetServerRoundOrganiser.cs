using UnityEngine.Networking;

namespace CoreNet.Components.Server
{
	public class NetServerRoundOrganiser : NetRoundOrganiser
	{
		public enum NetRoundType
		{
			ClientsLoaded = 0,
			GameSetup = 1,
			GameStart = 2,
			GameEnd = 3,
			PostGameEnd = 4,
			PreLevelLoad = 5,
			ClientJoined = 6
		}

		protected void Start()
		{
		}

		public void FlushEvents()
		{
		}

		public void SendTargettedEvent(NetRoundType type, NetworkConnection conn)
		{
		}

		private short GetMessageCodeForRoundType(NetRoundType type)
		{
			return 0;
		}
	}
}
