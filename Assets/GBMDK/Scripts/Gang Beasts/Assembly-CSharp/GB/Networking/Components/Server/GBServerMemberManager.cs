using CoreNet.Components.Server;
using CoreNet.Messaging.Messages;
using CoreNet.Objects;
using Femur;
using GB.Networking.Messages;
using GB.Networking.Objects;
using UnityEngine.Networking;

namespace GB.Networking.Components.Server
{
	public class GBServerMemberManager : NetServerMemberManager
	{
		private const float IDLE_GUEST_TIMEOUT = 60f;

		private float PAUSE_MENU_TIMEOUT_EXTENSION;

		private bool timeoutsEnabled;

		private bool _privateDisabled;

		private GBMultiplayServerCommunicator serverCommunicator;

		protected new void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void OnPrivateSet(NetInt result)
		{
		}

		private void CheckIdle(Actor actor)
		{
		}

		private void OnBeastNothing(NetBeast beast)
		{
		}

		private void OnBeastRemoved(NetBeast beast)
		{
		}

		private void OnPlatformNothing(NetPlatform plat)
		{
		}

		private void OnPlatformRemoved(NetPlatform plat)
		{
		}

		private void EnableTimeouts()
		{
		}

		private void DisableTimeouts()
		{
		}

		private void OnPauseStateChanged(NetBoolMessage msg, NetworkConnection conn)
		{
		}

		private void OnCleanupRequest(NetNullMessage message, NetworkConnection conn)
		{
		}

		protected override void OnMaxPlayersUpdated(int newMaxPlayers)
		{
		}

		protected override void RegisterCustomPlayersHandler()
		{
		}

		protected override void RemoveCustomPlayersFromMember(NetMember member)
		{
		}

		private void ReceiveAlteredVoipState(NetChatMessage msg, NetworkConnection conn)
		{
		}

		protected override AuthenticationResult Authenticate(NetworkConnection conn, NetAuthMessage message)
		{
			return default(AuthenticationResult);
		}

		protected override void FinaliseConnection(NetworkConnection conn, NetAuthMessage message, AuthenticationResult result)
		{
		}
	}
}
