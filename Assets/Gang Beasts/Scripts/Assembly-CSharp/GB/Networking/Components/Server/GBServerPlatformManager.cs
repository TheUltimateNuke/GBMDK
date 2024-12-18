using CS.CorePlatform.Server;
using CoreNet.Components;
using CoreNet.Objects;
using GB.Networking.Objects;
using UnityEngine.Networking;

namespace GB.Networking.Components.Server
{
	public class GBServerPlatformManager : NetComponent
	{
		private ServerPlayingWith _serverInfo;

		private new void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		public void SendUpdatedData()
		{
		}

		private void OnReceiveNetPlatform(NetPlatform platform, NetworkConnection conn)
		{
		}

		private void OnReceiveInfoUpdate(NetData message, NetworkConnection conn)
		{
		}

		private void OnClientConnectionNothing(NetConnection connection)
		{
		}

		private void OnClientConnectionRemoved(NetConnection connection)
		{
		}

		private void OnMemberNothing(NetMember member)
		{
		}

		private void OnMemberRemoved(NetMember member)
		{
		}

		private void CheckUsers(NetPlatform currentplatform, NetPlatform newplatform)
		{
		}

		private void AddPlatform(NetPlatform platform)
		{
		}

		private void LostPlatform(NetPlatform platform)
		{
		}
	}
}
