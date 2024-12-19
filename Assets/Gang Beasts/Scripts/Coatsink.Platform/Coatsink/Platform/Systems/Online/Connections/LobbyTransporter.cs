using System.Collections.Generic;
using Coatsink.Platform.Systems.User;

namespace Coatsink.Platform.Systems.Online.Connections
{
	public class LobbyTransporter : NetTransporter
	{
		private List<UserInfo> _connecting;

		private ILobby _targetedLobby;

		private object _stateLocker;

		private NetTransportUpdate _lastState;

		private NetTransportUpdate _currentState;

		private int _hostConnection;

		private bool _allowHostMigration;

		private bool _starConnection;

		public NetTransportUpdate ConnectionState => default(NetTransportUpdate);

		public bool AllowHostMigration
		{
			set
			{
			}
		}

		public ILobby Lobby
		{
			set
			{
			}
		}

		public int HostConnection => 0;

		public bool StarConnections
		{
			set
			{
			}
		}

		public override void Start()
		{
		}

		private void OnLobbyClosed(ILobby lobby, ILobbyID id)
		{
		}

		private void OnHostChanged(ILobby lobby, UserInfo user)
		{
		}

		public void ReconnectAllConnections()
		{
		}

		protected void CheckConnections()
		{
		}

		private void OnUserLeft(ILobby lobby, UserInfo user)
		{
		}

		private void OnUserJoin(ILobby lobby, UserInfo user)
		{
		}

		public override uint Receive(out int connectionID, out int channel, byte[] data, int dataMax, out int received, out NetTransportUpdate updateEvent)
		{
			connectionID = default(int);
			channel = default(int);
			received = default(int);
			updateEvent = default(NetTransportUpdate);
			return 0u;
		}

		private bool StillMigrating()
		{
			return false;
		}
	}
}
