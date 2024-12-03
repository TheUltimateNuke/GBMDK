using System.Net;
using Coatsink.Platform.Systems.User;
using Coatsink.Platform.Utils;

namespace Coatsink.Platform.Systems.Online.Connections
{
	public abstract class BaseNetConnection : INetConnection
	{
		public static Debug.Level DebugErrorLevel;

		private object _locker;

		private ConnectionStatus _statusCurrent;

		private ConnectionStatus _statusLast;

		protected UserInfo _connectionTo;

		protected int[] _connected;

		protected string[] _keys;

		public ConnectionStatus Status => default(ConnectionStatus);

		public uint Connect(UserInfo userConnect, string[] keys)
		{
			return 0u;
		}

		private void ConnectionReceived(TaskResult<UserInfo, string, EndPoint> connectTask)
		{
		}

		protected void CheckComplete(int channel, bool result)
		{
		}

		public uint Disconnect()
		{
			return 0u;
		}

		protected virtual void Disconnected()
		{
		}

		public virtual bool Update(out ConnectionStatus status)
		{
			status = default(ConnectionStatus);
			return false;
		}

		public virtual uint ConnectComplete(int channel, TaskResult<UserInfo, string, EndPoint> task)
		{
			return 0u;
		}

		public virtual bool CheckSender(UserInfo sender, EndPoint endPoint)
		{
			return false;
		}

		public abstract uint SendTo(int channel, byte[] data, uint amount);
	}
}
